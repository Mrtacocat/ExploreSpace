using MongoDB.Driver;
using Backend.Models;
using Microsoft.Extensions.Configuration;

namespace Backend.Models
{
    public class AccDataAccess
    {
        private readonly IMongoCollection<UserModel> _usersCollection;

        public AccDataAccess(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            var databaseName = configuration.GetValue<string>("DatabaseName");

            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(databaseName);
            _usersCollection = database.GetCollection<UserModel>("users");
        }

        public UserModel GetUserByUsername(string username)
        {
            return _usersCollection.Find(u => u.Username == username).FirstOrDefault();
        }

        public void RegisterUser(UserModel user)
        {
            _usersCollection.InsertOne(user);
        }
    }
}
