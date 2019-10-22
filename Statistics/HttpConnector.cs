using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Statistics
{
    public class HttpConnector : IHTTPConnector
    {
        public event Action<string> OnLoadStringComplete = delegate { };
        public event Action<string, string, Stream> OnLoadStreamComplete = delegate { };

        public string LoadString(string url) 
        {
            var request = CreateRequest(url);

            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            OnLoadStringComplete(responseString);
            return responseString;
        }

        #region private section
        private HttpWebRequest CreateRequest(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);

            request.Method = "GET";
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/63.0.3239.132 Safari/537.36";

            return request;
        }
        #endregion

    }
}
