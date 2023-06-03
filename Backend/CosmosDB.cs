namespace Backend;
using Microsoft.Extensions.Configuration;
public class CosmosDB
{
    private readonly IConfiguration _configuration;

    public CosmosDB(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void DoSomething()
    {
        int cosmosDbRu = _configuration.GetValue<int>("CosmosDbRU");
        // Use the cosmosDbRu value as needed in your code
    }
}
