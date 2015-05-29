using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using HelloWorld.json;
using System.Diagnostics;
using System.Threading.Tasks;
using HelloWorld.model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using HelloWorld.parser;
using System.Collections.ObjectModel;
using HelloWorld.ModelView;
using HelloWorld.View;

namespace HelloWorld
{
    public partial class MainPage : PhoneApplicationPage
    {
        private string response = null;
        private static string uri = "https://s3-sa-east-1.amazonaws.com/mobile-challenge/bill/bill.json";
               
        public MainPage()
        {
            InitializeComponent();
            PivotPlatform.ItemsSource = App.ViewModel.PivotItems;
          
        }

        private void ShowTextButton_Click(Object sender, RoutedEventArgs e){      
            WebClient webClient = new WebClient();
            webClient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(webClient_DownloadStringCompleted);
            webClient.DownloadStringAsync(new Uri(uri));
            if (response != null)
            {
                List<IBill> bills = JsonConvert.DeserializeObject<List<IBill>>(response, new BillConverter());
                Debug.WriteLine(bills);
            }
        }
        
        void webClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (!e.Cancelled && e.Error == null)
            {
                response = e.Result;
            }
        }
    }
}