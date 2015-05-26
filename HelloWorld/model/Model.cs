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
using System.Collections.Generic;
using System.Diagnostics;

namespace HelloWorld.model
{
    public class Summary
    {
        public DateTime Due_date { get; set; }
        public DateTime Close_date { get; set; }
        public double Past_balance { get; set; }
        public double Total_balance { get; set; }
        public double Interest { get; set; }
        public double Total_cumulative { get; set; }
        public double Paid { get; set; }
        public double Minimum_payment { get; set; }
        public DateTime Open_date { get; set; }
    }

    public class Self
    {
        public Uri Href { get; set; }
    }

    public class BoletoEmail
    {
        public Uri Href { get; set; }
    }

    public class Barcode
    {
        public Uri Href { get; set; }
    }

    public class Links
    {
        public Self Self { get; set; }
        public BoletoEmail Boleto_email { get; set; }
        public Barcode Barcode { get; set; }
    }

    public class LineItem
    {
        public DateTime Post_date { get; set; }
        public double Amount { get; set; }
        public string Title { get; set; }
        public int Index { get; set; }
        public int Charges { get; set; }
        public Uri Href { get; set; }
    }

    public interface IBill
    {
        void Add(IBill b);       
    }

    public class Bill : IBill
    {

        public string State { get; set; }
        public string Id { get; set; }
        public Summary Summary { get; set; }
        public Links _Links { get; set; }
        public string Barcode { get; set; }
        public string Linha_digitavel { get; set; }
        public List<LineItem> Line_items { get; set; }

        public void Add(IBill bill)
        {
            Console.WriteLine("Cannot add to a bill");
        }
    }


    public class Bills: IBill
    {
        public Bills()            
        {
            bills = new List<IBill>();
        }

        public void Add(IBill bill)
        {
            bills.Add(bill);

        }

        public List<IBill> bills { get; set; }
    }

}
