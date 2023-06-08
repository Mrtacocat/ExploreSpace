using Backend.Models;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();


string connectionString = configuration.GetConnectionString("DefaultConnection");
string databaseName = "UsersExploreSpace";
string collectionName = "people";


    var client = new MongoClient(connectionString);
    var db = client.GetDatabase(databaseName);
    var collection = db.GetCollection<PersonModel>(collectionName);

    var person = new PersonModel { Name = "Per Olav" };

    await collection.InsertOneAsync(person);

    var results = await collection.FindAsync(_ => true);

    foreach (var result in results.ToList())
    {
        Console.WriteLine(result.Name);
    }



public class DatabaseInitializer
{
    
    private readonly ILogger<DatabaseInitializer> _logger;

    public DatabaseInitializer(ILogger<DatabaseInitializer> logger)
    {
        _logger = logger;
    }

    public void Initialize()
    {
        // Code for establishing the database connection

        // Check the database connection status
        if (IsDatabaseConnected())
        {
            _logger.LogInformation("Database connected successfully.");
        }
        else
        {
            _logger.LogError("Failed to connect to the database.");
        }

        // Continue with other initialization tasks
    }

    private bool IsDatabaseConnected()
    {
        // Code to check the database connection status
        // Return true if the connection is successful, false otherwise

        return true;
    }
}