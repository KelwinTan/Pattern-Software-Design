using LW18_2_Web_Service_Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace LW18_2_Web_Service_Backend.Utilities
{
    public static class JSONHelper
    {
        public static T Deserializer<T>(this String json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public static string Serialize(object data)
        {
            return JsonConvert.SerializeObject(data, Formatting.None, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
        }

    }
}