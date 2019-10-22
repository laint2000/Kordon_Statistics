namespace Kordon_Statistics
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.panelFileList = new System.Windows.Forms.Panel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.btnRun = new System.Windows.Forms.Button();
            this.timerGetData = new System.Windows.Forms.Timer(this.components);
            this.txtLog = new System.Windows.Forms.TextBox();
            this.trayIconMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panelFileList.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayIconMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Kordon Statistics";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // trayIconMenu
            // 
            this.trayIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.trayIconMenu.Name = "trayIconMenu";
            this.trayIconMenu.Size = new System.Drawing.Size(104, 54);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.panelFileList);
            this.splitContainerMain.Panel1.Controls.Add(this.panelButton);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.btnRun);
            this.splitContainerMain.Size = new System.Drawing.Size(733, 473);
            this.splitContainerMain.SplitterDistance = 528;
            this.splitContainerMain.SplitterWidth = 3;
            this.splitContainerMain.TabIndex = 6;
            // 
            // panelFileList
            // 
            this.panelFileList.Controls.Add(this.txtLog);
            this.panelFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFileList.Location = new System.Drawing.Point(0, 0);
            this.panelFileList.Margin = new System.Windows.Forms.Padding(2);
            this.panelFileList.Name = "panelFileList";
            this.panelFileList.Size = new System.Drawing.Size(528, 441);
            this.panelFileList.TabIndex = 5;
            // 
            // panelButton
            // 
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 441);
            this.panelButton.Margin = new System.Windows.Forms.Padding(2);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(528, 32);
            this.panelButton.TabIndex = 4;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(2, 11);
            this.btnRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(125, 42);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // timerGetData
            // 
            this.timerGetData.Tick += new System.EventHandler(this.timerGetData_Tick);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.Window;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Location = new System.Drawing.Point(0, 0);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(528, 441);
            this.txtLog.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 473);
            this.Controls.Add(this.splitContainerMain);
            this.Name = "MainForm";
            this.Text = "Statistics";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.trayIconMenu.ResumeLayout(false);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.panelFileList.ResumeLayout(false);
            this.panelFileList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayIconMenu;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel panelFileList;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Timer timerGetData;
        private System.Windows.Forms.TextBox txtLog;
    }
}

