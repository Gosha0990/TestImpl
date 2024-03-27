// See https://aka.ms/new-console-template for more information
using ds.test.impl;

Console.WriteLine("Hello, World!");

var pluginFactory = new Plugins();

var pluginSum = pluginFactory.GetPlugin("PluginSum");

Console.WriteLine(pluginSum.Run(1, 1));
Console.ReadLine();