using System.Text.Json.Serialization;

public class CikTickerMapping
{
    [JsonPropertyName("cik_str")]
    public string Cik { get; set; }
    
    [JsonPropertyName("ticker")]
    public string Ticker { get; set; } = "";
    
    [JsonPropertyName("title")]
    public string Title { get; set; } = "";
}

// Models/CompanyTickersResponse.cs  
public class CompanyTickersResponse
{
    [JsonPropertyName("rank")]
    public List<CikTickerMapping> rank { get; set; } = new();
}