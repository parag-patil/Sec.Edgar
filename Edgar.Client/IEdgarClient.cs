namespace Edger.Client;

public interface IEdgarClient
{
    Task<CompanyTickersResponse?> GetCikAsync();
}