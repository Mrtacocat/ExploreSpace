using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Backend.Models;
using MongoDB.Driver;

namespace Backend.DataAccess
{
    public class AccountDataAccess
    {
        private const string ConnectionString = "mongodb://explorespaceaccount:ScGFZvIa5TbpvFbKQbU8BrWXRVOzs0pE8MkAJs2kx5hDcJv9RrAqiZ5TGEEhJWHjE9IGmbay7ZPXACDbhPiRlQ%3D%3D@explorespaceaccount.mongo.cosmos.azure.com:10255/?ssl=true&replicaSet=globaldb&retrywrites=false&maxIdleTimeMS=120000&appName=@explorespaceaccount@";
        private const string DatabaseName = "UsersExploreSpace";
        private const string UserCollection = "users";

        private IMongoCollection<UserModel> ConnectToMongo()
        {
            var client = new MongoClient(ConnectionString);
            var db = client.GetDatabase(DatabaseName);
            return db.GetCollection<UserModel>(UserCollection);
        }

        public async Task<List<UserModel>> GetAllUsers()
        {
            var usersCollection = ConnectToMongo();
            var results = await usersCollection.FindAsync(_ => true);
            return await results.ToListAsync();
        }

        public Task CreateUser(UserModel user)
        {
            var usersCollection = ConnectToMongo();
            return usersCollection.InsertOneAsync(user);
        }

        // Add other methods for interacting with the user collection as needed
    }
}