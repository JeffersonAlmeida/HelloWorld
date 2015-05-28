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
using HelloWorld.model;
using System.Collections.ObjectModel;
using HelloWorld.json;

namespace HelloWorld.ModelView
{
    public class MainViewModel
    {
        public ObservableCollection<IBill> PivotItems { get; set; }

        public MainViewModel()
        {
            PivotItems = JsonToBills.deserialize();
        }

    }
}
