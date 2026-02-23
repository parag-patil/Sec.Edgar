namespace Edger.Client;

public interface IEdgarClient
{
    Task<object?> GetCikAsync();
}