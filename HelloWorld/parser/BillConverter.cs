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
using Newtonsoft.Json.Linq;
using HelloWorld.model;
using System.Collections.Generic;

namespace HelloWorld.parser
{
    public class BillConverter : JsonCreationConverter<IBill>
    {
        private static string propertyName = "";
        protected override IBill Create(Type objectType, JObject jObject)
        {                     
            IEnumerable < JProperty > properties = jObject.Properties();
            foreach (JProperty p in properties)
            {
                propertyName = p.First.Path;
                break;
            }            

            if (propertyName.Equals("bill"))
            {
                String jsonString = jObject.ToString();
                JToken root = JObject.Parse(jsonString);
                return JsonConvert.DeserializeObject<Bill>(root["bill"].ToString());
            }
            else if (propertyName.Contains("bills"))
            {
                return new Bills();
            }
            else
            {
                String jsonString = jObject.ToString();
                JToken root = JObject.Parse(jsonString);
                return JsonConvert.DeserializeObject<Bill>(root.ToString());
            }
        }
    }
    }

    public abstract class JsonCreationConverter<T> : JsonConverter
    {
        protected abstract T Create(Type objectType, JObject jObject);

        public override bool CanConvert(Type objectType)
        {
            return typeof(T).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jObject = JObject.Load(reader);
            T target = Create(objectType, jObject);
            serializer.Populate(jObject.CreateReader(), target);
            return target;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }

