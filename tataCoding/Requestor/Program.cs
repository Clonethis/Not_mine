using System.Net.Http;
using System;
using System.IO;
namespace Requestor
{
    //na HTTPS://TESTNIA.SUKL.CZ/.  

    public class Req

    {

        //HttpClient client;
        //String loginUrl;
        //String statusUrl;
        //String tokenUrl;

        //String baseUrl = "https://testnia.sukl.cz/nia/ext/v1/login/";
        //String statusBaseUrl = "https://testnia.sukl.cz/nia/ext/v1/stav/";
        //String tokenBaseUrl = "https://testnia.sukl.cz/nia/ext/v1/token/";


        //baseUrlInput.Text = baseUrl;
        //statusInput.Text = statusBaseUrl;
        //tokenInput.Text = tokenBaseUrl;
        //param1Input.Text = System.Guid.NewGuid().ToString();

        //// slozeni url pro login volani NIA 
        //string loginUrl = baseUrlInput.Text + param1Input.Text + "/osoba/" + param2Input.Text + "?redirect=false";

        //    // slozeni url pro ziskani stavu NIA 
        //    string statusUrl = statusInput.Text + param1Input.Text;

        //    // slozeni url pro ziskani tokenu NIA 
        //    string tokenUrl = tokenInput.Text + param1Input.Text;

        //    String res;
        private static readonly HttpClient client = new HttpClient();

        public async static Task<string> Request()
        {
            string responseString = await client.GetStringAsync("https://common-soap.test-erecept.sukl.cz/");
            return responseString;
        }


        //
        public static async void ReturnRequest()
        {
            try
            {
                string response = await Request();
                Console.WriteLine(response);
                //return response;
            }
            catch (Exception e)
            {
                Console.WriteLine("Failed miserably: " + e);
                //return "Failed";
            }
        }

        // main struct
        static void Main(string[] args)
        {

            //ReturnRequest();
            Soap.CallWebService();
            Console.WriteLine(client);
            Console.ReadKey();
            //Task<string> response = Request();
            //Console.Write(response);
        }
    }
}
