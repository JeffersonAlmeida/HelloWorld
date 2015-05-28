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

namespace HelloWorld.json
{
    public static class JsonToBills
    {
        public static ObservableCollection<IBill> deserialize()
        {
            return JsonConvert.DeserializeObject<ObservableCollection<IBill>>(JsonString.getJsonString(), new BillConverter());
        }
    }
}
