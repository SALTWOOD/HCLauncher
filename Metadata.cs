using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HCL
{
    public static class Metadata
    {
        public readonly static string name = "HCL";
        public readonly static string fullName = "Hydrogen Craft Launcher";
        public readonly static string version = "1.0.0";

        public readonly static string userAgent = $"{fullName}/{version}";

        public readonly static string title = $"{name} v{version}";
        public readonly static string fullTitle = $"{fullName} (version {version})";

        public readonly static bool DEBUG = false;

        public readonly static int protocol = 0x00_00_00_05;
    }
}
