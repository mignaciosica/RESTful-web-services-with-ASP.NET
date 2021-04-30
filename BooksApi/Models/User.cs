using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace BooksApi.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        [JsonProperty("Name")]
        public string Username { get; set; }

        [BsonElement("auth0_id")]
        [JsonProperty("auth0_id")]
        public string Auth0Id { get; set; }

        public string Password { get; set; }
    }
}
