using Microsoft.Extensions.Configuration;

public class ConfigurationManager
{
    private readonly IConfiguration _configuration;

    public ConfigurationManager(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void DoSomething()
    {
        int cosmosDbRu = _configuration.GetValue<int>("CosmosDbRU");
        // Use the cosmosDbRu value as needed in your code
    }
}
