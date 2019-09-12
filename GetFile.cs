using System;
using System.IO;
using System.Net;
using System.Text;

namespace ringba_test
{
    public static class GetFile
    {
        public static String FromUrl(String url)
        {
            WebRequest webRequest = WebRequest.Create(url);
            WebResponse webResp = webRequest.GetResponse();
            using (Stream stream = webResp.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                String responseString = reader.ReadToEnd();
                return responseString;
            }
        } 
    }
}