using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCLauncher.Modules.JsonTemplates
{
#nullable disable
    public class Library
    {
        [JsonProperty("downloads.artifact")] public GenericAssetInfo artifact;
        public string name;
    }
}
