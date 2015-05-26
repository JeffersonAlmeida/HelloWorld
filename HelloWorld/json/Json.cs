using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using System.Diagnostics;
using HelloWorld.model;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace HelloWorld.json
{
    public class GetJson
    {
        private String response = "response";
        

        public void m()
        {

            dynamic json = JValue.Parse(response);
           
            /*
            WebClient webClient = new WebClient();
            webClient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(webClient_DownloadStringCompleted);
            webClient.DownloadStringAsync(new Uri(uri));
            
            Debug.WriteLine("response: " + response);

            */

     
        }

        public async void method(string s)
        {
            string uri = "https://s3-sa-east-1.amazonaws.com/mobile-challenge/bill/bill.json";
            var client = new WebClient();
            string page = await client.DownloadStringTaskAsync(uri);
            s = page;
            if (page.Contains("2015-06-15") == true)
            {
                Debug.WriteLine("contem");
            }
            else
            {
                Debug.WriteLine("nao contem");
            }

            Debug.WriteLine("response: " + page);
        }

        private async void RequestData(string uri, Action<string> action)
        {
            var client = new WebClient();
            string data = await client.DownloadStringTaskAsync(uri);
            action(data);
        }

       

        void webClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {

            if (!e.Cancelled && e.Error == null)
            {
                string textString = (string)e.Result;

                Console.WriteLine(textString);
                Debug.WriteLine(e.Result);
                response = e.Result;
            
               
            }
            
            

            
            /*Bills bills = JsonConvert.DeserializeObject<Bills>(e.Result);
            if (bills != null)
            {
                Debug.WriteLine("array length() = " + bills.bills.Count );
            }*/

        }
    }
}
