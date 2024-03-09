using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCLauncher.Modules
{
    public static class FolderPath
    {
        public static string path = TextString.SlashReplace(AppDomain.CurrentDomain.SetupInformation.ApplicationBase!);
        public static string pathMCFolder = $"{TextString.SlashReplace(AppDomain.CurrentDomain.SetupInformation.ApplicationBase!)}.minecraft/";
    }
}
