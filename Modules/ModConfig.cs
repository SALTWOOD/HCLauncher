﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HCL.Constants;

namespace HCL.Modules
{
    public static class ModConfig
    {
        #region 配置读取
        public static void WriteConfig(Config config)
        {
            StreamWriter sw = new StreamWriter($"{ModPath.path}HCL/settings.json");
            sw.Write(JsonConvert.SerializeObject(config));
            sw.Close();
        }

        public static Config ReadConfig()
        {
            Config result;
            using (StreamReader sr = new StreamReader($"{ModPath.path}HCL/settings.json"))
            {
                result = JsonConvert.DeserializeObject<Config>(sr.ReadToEnd())!;
            }
            return result;
        }
        #endregion

        public class Config
        {
            public List<List<object>>? java = new();
            public bool logAutomaticCleanup = true;
            public int logFileAutomaticCleanupInterval = 7;
            public int tempValidTime = 7 * 24 * 60 * 60;
            public long tempTime = 0;
            public bool forceDisableJavaAutoSearch = false;
            public bool forceJavaFullSearch = false;
            public string language = "zh-cn";
        }
    }
}
