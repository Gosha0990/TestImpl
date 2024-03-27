using ds.test.impl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib.Services
{
    internal class PluginError : IPlugin
    {
        public string PluginName => throw new NotImplementedException();

        public string Version => throw new NotImplementedException();

        public Image Image => throw new NotImplementedException();

        public string Description => throw new NotImplementedException();

        public int Run(int input1, int input2)
        {
            throw new NotImplementedException();
        }
    }
}
