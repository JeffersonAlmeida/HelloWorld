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
using System.Windows.Data;

namespace HelloWorld.View
{
    public class PivotTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Overdue { get; set; }
        public DataTemplate Open { get; set; }
        public DataTemplate Closed { get; set; }
        public DataTemplate Future { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {

            Bill Item = item as Bill;
            if (Item != null)
            {
                if (Item.State == "overdue")
                {
                    return Overdue;
                }
                else if (Item.State == "open")
                {
                    return Open;
                }
                else if (Item.State == "closed")
                {
                    return Closed;
                }
                else
                {
                    return Future;
                }
            }

            return base.SelectTemplate(item, container);
        }
    }

    public abstract class DataTemplateSelector : ContentControl
    {
        public virtual DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            return null;
        }

        protected override void OnContentChanged(object oldContent, object newContent)
        {
            base.OnContentChanged(oldContent, newContent);
            ContentTemplate = SelectTemplate(newContent, this);
        }
    }
}
