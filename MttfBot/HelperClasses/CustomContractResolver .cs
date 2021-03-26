using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MttfBot.HelperClasses
{
    public class CustomContractResolver : DefaultContractResolver
    {
        private Dictionary<string, string> PropertyMappings { get; set; }

        public CustomContractResolver()
        {
            PropertyMappings = new Dictionary<string, string>
            {
            //Callback section
                {"type", "Type"},
                {"object", "Object"},
                {"group_id", "GroupID"},
                {"event_id", "EventID"},
                {"secret", "Secret"},

            //WindyPointRequest section
                {"lat", "Latitude"},
                {"lon", "Longitude"},
                {"model", "Model"},
                {"parameters", "Parameters"},
                {"levels", "Levels"},
                {"key", "Key"},

            //WindyPointResponse
                {"ts", "Timestamp"},
                {"units", "Units"},
                {"wind_u-surface", "WindUSurface"},
                {"wind_v-surface", "WindVSurface"},
                {"dewpoint-surface", "DewpointSurface"},
                {"rh-surface", "RhSurface"},
                {"pressure-surface", "PressureSurface"}
            };
        }

        protected override string ResolvePropertyName(string property)
        {
            string res = null;
            bool resolved = PropertyMappings.TryGetValue(property, out res);
            return resolved ? res : base.ResolvePropertyName(property);
        }
    }
}
