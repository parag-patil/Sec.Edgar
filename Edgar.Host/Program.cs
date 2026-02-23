// See https://aka.ms/new-console-template for more information

using Edger.Client;
using Edger.Client.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
builder.Services.AddEdgarClient();
var app = builder.Build();

var client = app.Services.GetRequiredService<IEdgarClient>();
var mappings = await client.GetCikAsync();

var m = mappings;
