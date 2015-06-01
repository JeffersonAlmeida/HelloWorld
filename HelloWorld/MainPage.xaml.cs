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
using System.Threading;
using System.Net.NetworkInformation;
using HelloWorld.Exceptions;

namespace HelloWorld
{
    public partial class MainPage : PhoneApplicationPage
    {

        public MainPage()
        {
            InitializeComponent();
            runViewModel();
        }

        public async void runViewModel()
        {
            string json = await DownloadJson();
            MainViewModel mainViewModel = new MainViewModel(json);
            PivotPlatform.ItemsSource = mainViewModel.PivotItems;
        }

        public Task<string> DownloadJson()
        {
            var tcs = new TaskCompletionSource<string>();
            var client = new WebClient();
            client.DownloadStringCompleted += (s, e) =>
            {
               string download = null;
               try
               {
                   download = e.Result;
                   tcs.SetResult(download);
               }
               catch (Exception ex)
               {
                   NubankExceptions nubankExceptions = new NubankExceptions((WebException)ex);
                   nubankExceptions.handle();
               }
               if (download == null)
               {
                   return;
               }
            };
            string uri = "https://s3-sa-east-1.amazonaws.com/mobile-challenge/bill/bill.json";
            client.DownloadStringAsync(new Uri(uri));
            return tcs.Task;
        }
    }

}
    