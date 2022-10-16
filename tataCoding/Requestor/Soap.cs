using System.Xml;
using System.Net;
using System.IO;

namespace Requestor
{
    public class Soap
    {

        public static void CallWebService()
        {
            // sukl
            var _url = "https://common-soap.test-erecept.sukl.cz/";
            var _action = "https://testapi.sukl.cz/epoukaz/v1/pracoviste/00000004514";
            //var _url = "https://wwwinfo.mfcr.cz/cgi-bin/ares/darv_std.cgi";
            //var _action = "https://wwwinfo.mfcr.cz/cgi-bin/ares/darv_std.cgi?ico=";
            var soapEnvelopeXml = CreateSoapEnvelope();
            HttpWebRequest webRequest = CreateWebRequest(_url);
            InsertSoapEnvelopeIntoWebRequest(soapEnvelopeXml, webRequest);

            // begin async call to web request.
            Console.WriteLine("Request: ", webRequest);
            IAsyncResult asyncResult = webRequest.BeginGetResponse(null, null);

            // suspend this thread until call is complete. You might want to
            // do something usefull here like update your UI.
            asyncResult.AsyncWaitHandle.WaitOne();
            Console.WriteLine("Async result",asyncResult);


            // get the response from the completed web request.
            string soapResult;
            using (WebResponse webResponse = webRequest.EndGetResponse(asyncResult))
            {
                using (StreamReader rd = new StreamReader(webResponse.GetResponseStream()))
                {
                    soapResult = rd.ReadToEnd();
                }
                Console.Write(soapResult);
            }
        }

        private static HttpWebRequest CreateWebRequest(string url)
        {
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            //webRequest.Headers.Add("name","AppPing");
            webRequest.ContentType = "text/xml;charset=\"utf-8\"";
            webRequest.Accept = "text/xml";
            webRequest.Method = "POST";
            return webRequest;
        }

        private static XmlDocument CreateSoapEnvelope()
        {
            XmlDocument soapEnvelopeDocument = new XmlDocument();
            //"<soapenv:Envelope xmlns:soapenv=\"http://schemas.xmlsoap.org/soap/envelope/\" xmlns:com=\"http://www.sukl.cz/erp/common\">\n    <soapenv:Header/>\n    <soapenv:Body>\n        <com:AppPingDotaz>\n            <com:Doklad>\n                <com:Pristupujici>\n                    <com:Uzivatel>669cac52-b591-4276-8815-f81a2f97192a</com:Uzivatel>\n                    <com:Pracoviste>00000909047</com:Pracoviste>\n                </com:Pristupujici>\n            </com:Doklad>\n            <com:Zprava>\n                <com:ID_Zpravy>a9220c59-708c-4468-bc28-feb6d08acde1</com:ID_Zpravy>\n                <com:Verze>202201A</com:Verze>\n                <com:Odeslano>2021-09-03T09:07:21.552+02:00</com:Odeslano>\n                <com:SW_Klienta>0123456789AB</com:SW_Klienta>\n            </com:Zprava>\n        </com:AppPingDotaz>\n    </soapenv:Body>\n</soapenv:Envelope>"
            soapEnvelopeDocument.LoadXml(
            @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:com=""http://www.sukl.cz/erp/common"">
    <soapenv:Header/>
    <soapenv:Body>
        <com:AppPingDotaz>
            <com:Doklad>
                <com:Pristupujici>
                    <com:Uzivatel>669cac52-b591-4276-8815-f81a2f97192a</com:Uzivatel>
                    <com:Pracoviste>00000909047</com:Pracoviste>
                </com:Pristupujici>
            </com:Doklad>
            <com:Zprava>
                <com:ID_Zpravy>a9220c59-708c-4468-bc28-feb6d08acde1</com:ID_Zpravy>
                <com:Verze>202201A</com:Verze>
                <com:Odeslano>2021-09-03T09:07:21.552+02:00</com:Odeslano>
                <com:SW_Klienta>0123456789AB</com:SW_Klienta>
            </com:Zprava>
        </com:AppPingDotaz>
    </soapenv:Body>
</soapenv:Envelope>
");
            return soapEnvelopeDocument;
        }

        private static void InsertSoapEnvelopeIntoWebRequest(XmlDocument soapEnvelopeXml, HttpWebRequest webRequest)
        {
            //if(webRequest.Method == "GET")
            //{
            //    Console.Write("WebRequest: ",webRequest);
            //}
            //else
            //{
                Console.WriteLine("nice");
                using (Stream stream = webRequest.GetRequestStream())
                {
                    soapEnvelopeXml.Save(stream);
                }

            //}
        }
    }
}

