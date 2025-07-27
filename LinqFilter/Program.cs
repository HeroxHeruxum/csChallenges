// See https://aka.ms/new-console-template for more information
using LinqFilter.services.parsing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

Console.WriteLine("Hello, World!");


HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
builder.Services.AddSingleton<IArrayParserService, ArrayParserService>();

using IHost host = builder.Build();
host.Run();