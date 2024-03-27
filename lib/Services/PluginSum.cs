using ds.test.impl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib.Services
{
    internal class PluginSum : IPlugin
    {
        public string PluginName { get; }

        public string Version { get; }

        public Image Image { get; }

        public string Description { get; }

        public PluginSum(string pluginName, string version, Image image, string description)
        {
            PluginName = pluginName;
            Version = version;
            Image = image;
            Description = description;
        }

        public int Run(int input1, int input2)
        {
            int result = 0;

            try
            {
                result = input1 + input2;
            }
            catch 
            { }

            return result;
        }
    }
}
