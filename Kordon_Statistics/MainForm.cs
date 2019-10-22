using Kordon_Statistics.Code;
using Statistics;
using Statistics.Fakes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kordon_Statistics
{
    public partial class MainForm : Form
    {
        private Downloader _downloader;
        private DateTime _lastCheck = new DateTime();
        private const int CheckInterval = 15; //Minutes

        public MainForm()
        {
            InitializeComponent();

            _downloader = CreateDownloader();
            timerGetData.Interval = 1000;
            timerGetData.Enabled = true;
        }

        private Downloader CreateDownloader() 
        {
            //var connector = new HttpConnectorFake(@"../../../TestData/UaPol.html");
            var connector = new HttpConnector();

            var htmlParser = new HtmlParser();
            var fileUaPol = new FileStatisticWriter("Border_UaPol.txt");
            var filePolUa = new FileStatisticWriter("Border_PolUa.txt");

            return new Downloader(connector, htmlParser, fileUaPol, filePolUa);
        }


        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) { return; }

            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                //trayIcon.Visible = true;
                this.Hide();
            }
        }


        private void btnRun_Click(object sender, EventArgs e)
        {
            ProcessData();
        }

        private void timerGetData_Tick(object sender, EventArgs e)
        {
            var currentTime = DateTime.Now;

            if (currentTime.Minute % CheckInterval != 0) return;
            if (currentTime.Minute == _lastCheck.Minute) return;

            _lastCheck = currentTime;

            ProcessData(currentTime);
        }

        private void ProcessData(DateTime? time = null) 
        {
            _downloader.ProcessData();

            var logTime = time ?? DateTime.Now;
            txtLog.Lines.Append($"{logTime} - new data added");
        }
    }
}
