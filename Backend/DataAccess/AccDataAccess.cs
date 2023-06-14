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
            var client = new MongoClient(connectionString);
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var database = client.GetDatabase(databaseName);
            _usersCollection = database.GetCollection<UserModel>("Users");
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
