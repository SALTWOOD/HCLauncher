using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCLauncher.Modules.DownloadSources
{
    public abstract class DownloadSource
    {
        public virtual string VersionList { get; set; } = "";

        // Forge
        public virtual string ForgeInstaller { get; set; } = "";

        // Fabric
        public virtual string FabricInstaller { get; set; } = "";
    }
}
