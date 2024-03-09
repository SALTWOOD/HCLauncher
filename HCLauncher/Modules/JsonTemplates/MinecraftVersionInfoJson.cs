using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCLauncher.Modules.JsonTemplates
{
#nullable disable
    public class MinecraftVersionInfoJson
    {
        public List<object> arguments;
        public GenericAssetInfo assetIndex;
        public string assets;
        public int complianceLevel;
        public string id;
        public List<object> javaVersion;
    }
}
