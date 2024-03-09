using HCLauncher.Modules.JsonTemplates;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCLauncher.Modules
{
    public class GameVersion
    {
        public string GameDirectory { get; private set; }
        public string VersionCustomName { get; private set; }

        public GameVersion(string versionCustomName)
        {
            VersionCustomName = versionCustomName;
            GameDirectory = $"{FolderPath.pathMCFolder}versions/{VersionCustomName}/";
        }

        public Exception? Download()
        {
            var text = File.ReadAllText($"{GameDirectory}{VersionCustomName}");
            var json = JsonConvert.DeserializeObject<MinecraftVersionInfoJson>(text);
        }
    }
}
