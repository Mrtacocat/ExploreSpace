using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Backend.Models
{
    public class UserModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Username")]
        public string Username { get; set; }

        [BsonElement("Password")]
        public string Password { get; set; }

        [BsonElement("Email")]
        public string Email { get; set; }
    }
}