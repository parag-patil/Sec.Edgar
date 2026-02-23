using System.Net.Http.Json;
using System.Text.Json;

namespace Edger.Client;

public class EdgarClient(HttpClient client) : IEdgarClient
{
    private readonly HttpClient _client = client;
    
    public async Task<object> GetCikAsync()
    {
        var response = await _client.GetAsync("files/company_tickers.json");
        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync();
        //return await response.Content.ReadFromJsonAsync<CompanyTickersResponse>();
        
        var companies = JsonSerializer.Deserialize<Dictionary<string, CompanyInfo>>(json);
        return companies;
    }
}