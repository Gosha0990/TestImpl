// See https://aka.ms/new-console-template for more information
using ds.test.impl;

Console.WriteLine("Hello, World!");

var pluginFactory = new Plugins();

var pluginSum = pluginFactory.GetPlugin("PluginSum");

Console.WriteLine(pluginSum.Run(1, 1));

var pluginMul = pluginFactory.GetPlugin("PluginMultiplication");

Console.WriteLine(pluginMul.Run(2, 4));

var pluginSubtract = pluginFactory.GetPlugin("PluginSubtract");

Console.WriteLine(pluginSubtract.Run(9, 5));

var pluginDiv = pluginFactory.GetPlugin("PluginDivision");

Console.WriteLine(pluginDiv.Run(6, 5));

var pluginError = pluginFactory.GetPlugin("test");

Console.WriteLine(pluginError.Run(1,1));

Console.ReadLine();