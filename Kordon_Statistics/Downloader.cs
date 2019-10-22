using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kordon_Statistics.Code;
using Statistics;
using Statistics.Fakes;

namespace Kordon_Statistics
{
    class Downloader
    {
        const string urlUaPol = "http://kordon.sfs.gov.ua/uk/home/countries/pl/o";
        const string urlPolUa = "http://kordon.sfs.gov.ua/uk/home/countries/pl/i";

        private IHTTPConnector _connector;
        private IHtmlParser _htmlParser;
        private IFileStatisticWriter _fileStatiscticsUaPol;
        private IFileStatisticWriter _fileStatiscticsPolUa;

        public Downloader(IHTTPConnector connector, IHtmlParser htmlParser, 
            IFileStatisticWriter fileUaPol, IFileStatisticWriter filePolUa)
        {
            _connector = connector;
            _htmlParser = htmlParser;
            _fileStatiscticsUaPol = fileUaPol;
            _fileStatiscticsPolUa = filePolUa;
        }

        public void ProcessData() 
        {
            var htmlUaPol = _connector.LoadString(urlUaPol);
            var htmlPolUa = _connector.LoadString(urlPolUa);

            var valueUaPol = _htmlParser.Parse(htmlUaPol);
            var valuePolUa = _htmlParser.Parse(htmlPolUa);

            _fileStatiscticsUaPol.AppendValue(valueUaPol);
            _fileStatiscticsPolUa.AppendValue(valuePolUa);
        }
    }
}
