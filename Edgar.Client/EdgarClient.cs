using System.Net.Http.Json;

namespace Edger.Client;

public class EdgarClient(HttpClient client) : IEdgarClient
{
    private readonly HttpClient _client = client;
    
    public async Task<CompanyTickersResponse> GetCikAsync()
    {
        var response = await _client.GetAsync("files/company_tickers.json");
        response.EnsureSuccessStatusCode();
        
        return await response.Content.ReadFromJsonAsync<CompanyTickersResponse>();
    }
}