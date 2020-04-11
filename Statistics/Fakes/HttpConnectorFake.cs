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
        public event Action<string> OnLoadStringComplete = delegate { };

        public string LoadString(string fileName)
        {
            var responseString = File.ReadAllText(fileName);

            OnLoadStringComplete(responseString);
            return responseString;
        }
    }
}
