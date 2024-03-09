using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCLauncher.Modules.DownloadSources
{
    public sealed class OfficialDownloadSource : DownloadSource
    {
        public override string VersionList { get; set; } = "https://launchermeta.mojang.com/mc/game/version_manifest.json";

        // Forge
        public override string ForgeInstaller { get; set; } = "";

        // Fabric
        public override string FabricInstaller { get; set; } = "";
    }
}
