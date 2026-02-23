using System;
using Microsoft.Extensions.DependencyInjection;
using Edger.Client;

namespace Edger.Client.DependencyInjection;

public static class EdgerClientDependencyInjection
{
    public static IServiceCollection AddEdgarClient(this IServiceCollection services)
    {
        services.AddHttpClient<IEdgarClient, EdgarClient>(client =>
        {
            client.BaseAddress = new Uri("https://www.sec.gov/");
            client.DefaultRequestHeaders.Add("User-Agent", "StockForge/1.0 (paddy@stockforge.ai)");
            client.Timeout = TimeSpan.FromSeconds(30);
        });
    
        return services;
    }
}