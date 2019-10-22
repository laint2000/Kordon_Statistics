using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistics.Fakes
{
    public class HttpConnectorFake : IHTTPConnector
    {
        //@"../../TestDataFiles/top20.html"
        private string _fileName;

        public HttpConnectorFake(string fileName)
        {
            _fileName = fileName;
        }

        public event Action<string> OnLoadStringComplete = delegate { };

        public string LoadString(string url)
        {
            var responseString = File.ReadAllText(_fileName);

            OnLoadStringComplete(responseString);
            return responseString;
        }
    }
}
