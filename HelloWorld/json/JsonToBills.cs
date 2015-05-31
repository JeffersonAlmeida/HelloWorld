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
using System.Collections.ObjectModel;
using HelloWorld.model;
using Newtonsoft.Json;
using HelloWorld.parser;
using System.Collections.Generic;

namespace HelloWorld.json
{
    public static class JsonToBills
    {
        public static ObservableCollection<IBill> deserialize(string jsonString)
        {
            ObservableCollection<IBill> observableCollection = new ObservableCollection<IBill>();



            IList<IBill> Ibills = JsonConvert.DeserializeObject<IList<IBill>>(jsonString, new BillConverter());
            foreach(IBill item in Ibills)
            {
                if (item is Bill)
                {
                    observableCollection.Add(item);
                }else if (item is Bills)
                {
                    foreach (IBill bill in ((Bills)item).bills) { observableCollection.Add(bill); }
                }
            }
            return observableCollection;
        }
    }
}
