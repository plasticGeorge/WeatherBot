using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

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
                {"Type", "type"},
                {"Object", "object"},
                {"GroupID", "group_id"},
                {"EventID", "event_id"},
                {"Secret", "secret"},

            //WindyPointRequest section
                {"Latitude", "lat"},
                {"Longitude", "lon"},
                {"Model", "model"},
                {"Parameters", "parameters"},
                {"Levels", "levels"},
                {"Key", "key"},

            //WindyPointResponse
                {"Timestamp ", "ts"},
                {"Units", "units"},
                {"WindUSurface", "wind_u-surface"},
                {"WindVSurface", "wind_v-surface"},
                {"DewpointSurface", "dewpoint-surface"},
                {"RhSurface", "rh-surface"},
                {"PressureSurface", "pressure-surface"}
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
