using ds.test.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib.Interfaces
{
    internal interface IPluginFactory
    {
        public int PluginsCount { get; }
        public string[] GetPluginNames { get; }
        public IPlugin GetPlugin(string pluginName);
    }
}
