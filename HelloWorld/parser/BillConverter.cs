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
    public class BillConverter : JsonCreationConverter<Component>
    {
        protected override Component Create(Type objectType, JObject jObject)
        {                        

            String propertyName = "";
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
                JToken user = root["bill"];
                Component bill = JsonConvert.DeserializeObject<Bill>(user.ToString());
                return bill;
            }
            else if (propertyName.Contains("bills"))
            {

                Component carros = new Bills();
                return carros;

            }
            else
            {
                String jsonString = jObject.ToString();
                JToken root = JObject.Parse(jsonString);
                Component bill = JsonConvert.DeserializeObject<Bill>(root.ToString());
                return bill;
            }
        }
    }
    }

    public abstract class JsonCreationConverter<T> : JsonConverter
    {
        /// <summary>
        /// Create an instance of objectType, based properties in the JSON object
        /// </summary>
        /// <param name="objectType">type of object expected</param>
        /// <param name="jObject">contents of JSON object that will be deserialized</param>
        /// <returns></returns>
        protected abstract T Create(Type objectType, JObject jObject);

        public override bool CanConvert(Type objectType)
        {
            return typeof(T).IsAssignableFrom(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // Load JObject from stream
            JObject jObject = JObject.Load(reader);

            // Create target object based on JObject
            T target = Create(objectType, jObject);

            // Populate the object properties
            serializer.Populate(jObject.CreateReader(), target);

            return target;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }

