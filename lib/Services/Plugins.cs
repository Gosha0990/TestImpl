using lib.Interfaces;
using lib.Services;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ds.test.impl
{
    /// <summary>
    /// Ксласс для создания плагинов
    /// </summary>
    public class Plugins : IPluginFactory
    {
        /// <summary>
        /// Количество доступных плагинов
        /// </summary>
        public int PluginsCount { get; }
        /// <summary>
        /// Список имен плагинов
        /// </summary>
        public string[] GetPluginNames {  get; }

        private ConcurrentDictionary<string, IPlugin> _plugins = new ConcurrentDictionary<string, IPlugin>();

        /// <summary>
        /// Конструктор
        /// </summary>
        public Plugins() 
        {
            AddPluginSum();
            AddPluginSubtract();
            AddPluginDivision();
            AddPluginMultiplication();

            PluginsCount = _plugins.Count;
            GetPluginNames = _plugins.Keys.ToArray();
        }

        /// <summary>
        /// Возвращает необходимый плагин по имяни
        /// </summary>
        /// <param name="pluginName"></param>
        /// <returns></returns>
        public IPlugin GetPlugin(string pluginName)
        {
            if (_plugins.TryGetValue(pluginName, out var plugin))
            {
                return plugin;
            }
            else
            {
                return new PluginError();
            }
        }

        private void AddPluginSum()
        {
            var pluginName = typeof(PluginSum).Name;

            var pluginSum = new PluginSum(pluginName, Environment.Version.Build.ToString(), new Bitmap(Environment.CurrentDirectory + @"\\Images\\plus.png"), "Сложение двух чисел");
            _plugins.TryAdd(pluginName, pluginSum);
        }

        private void AddPluginDivision()
        {
            var pluginName = typeof(PluginDivision).Name;

            var pluginDivision = new PluginDivision(pluginName, Environment.Version.Build.ToString(), null, "Деление двух чисел");
            _plugins.TryAdd(pluginName, pluginDivision);
        }

        private void AddPluginMultiplication()
        {
            var pluginName = typeof(PluginMultiplication).Name;

            var pluginMultiplication = new PluginMultiplication(pluginName, Environment.Version.Build.ToString(), null, "Умножение двух чисел");
            _plugins.TryAdd(pluginName, pluginMultiplication);
        }

        private void AddPluginSubtract()
        {
            var pluginName = typeof(PluginSubtract).Name;

            var pluginSubtract = new PluginSubtract(pluginName, Environment.Version.Build.ToString(), null, "Вычитание двух чисел");
            _plugins.TryAdd(pluginName, pluginSubtract);
        }
    }
}
