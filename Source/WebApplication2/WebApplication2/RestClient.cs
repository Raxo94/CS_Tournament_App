using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.IO;
using System.Text;
namespace RestClient_Namespace
{
    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    public class RestClient
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }
        public string ContentType { get; set; }
        public string PostData { get; set; }

        public RestClient()
        {
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;
            ContentType = "text/xml";
            PostData = "";
        }
        public RestClient(string endpoint, httpVerb method, string postData)
        {
            endPoint = endpoint;
            httpMethod = method;
            ContentType = "text/xml";
            PostData = postData;
        }

        public string makeRequest()
        {
            return makeRequest("");
        }

        public string makeRequest(string parameters)
        {
            string strResponseValue = string.Empty;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint + parameters);
                request.Method = httpMethod.ToString();
                request.ContentLength = 0;
                //request.ContentType = ContentType;


                //POST
                if (!string.IsNullOrEmpty(PostData) && httpMethod == httpVerb.POST)
                {
                    var encoding = new UTF8Encoding();
                    var bytes = Encoding.GetEncoding("iso-8859-1").GetBytes(PostData);
                    request.ContentLength = bytes.Length;

                    using (var writeStream = request.GetRequestStream())
                    {
                        writeStream.Write(bytes, 0, bytes.Length);
                    }
                }
                //ENDOFPOST

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new ApplicationException("error code: " + response.StatusCode);
                    }

                    using (Stream responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                strResponseValue = reader.ReadToEnd();
                            }
                        }
                    }
                }
            }
            catch(Exception e)
            {
                strResponseValue = e.ToString();
            }
            return strResponseValue;
        }
    }
}