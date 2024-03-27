using lib.Interfaces;
using System.Drawing;

namespace ds.test.impl
{
    /// <summary>
    /// Интерфейс плагинов
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        /// Имя плагина
        /// </summary>
        public string PluginName { get; }
        /// <summary>
        /// Версия плагина
        /// </summary>
        public string Version { get; }
        /// <summary>
        /// Изображение плагина
        /// </summary>
        public Image Image { get; }
        /// <summary>
        /// Описание плагина
        /// </summary>
        public string Description { get; }
        /// <summary>
        /// Запуск плагина
        /// </summary>
        /// <param name="input1"></param>
        /// <param name="input2"></param>
        /// <returns></returns>
        public int Run(int input1, int input2);

    }
}
