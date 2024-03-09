using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCLauncher.Modules
{
    public static class TextString
    {
        public static string SlashReplace(string raw) => raw.Replace("\\\\", "\\").Replace("\\", "/");
    }
}
