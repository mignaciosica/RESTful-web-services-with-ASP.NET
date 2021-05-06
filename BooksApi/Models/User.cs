using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace BooksApi.Models
{
    // public class User
    // {
    //     [BsonId]
    //     [BsonRepresentation(BsonType.ObjectId)]
    //     public string Id { get; set; }
    //
    //     [BsonElement("Name")]
    //     [JsonProperty("Name")]
    //     public string Username { get; set; }
    //
    //     [BsonElement("auth0_id")]
    //     [JsonProperty("auth0_id")]
    //     public string Auth0Id { get; set; }
    //
    //     public string Password { get; set; }
    //     
    //     [BsonElement("user_data")]
    //     [JsonProperty("user_data")]
    //     public string UserData { get; set; }
    // }
    
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("_id")]
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [BsonElement("user_data")]
        [JsonProperty("user_data")]
        public UserData UserData { get; set; }
    }

    public class UserData
    {
        [BsonElement("auth0_id")]
        [JsonProperty("auth0_id")]
        public string Auth0Id { get; set; }

        [BsonElement("email")]
        [JsonProperty("email")]
        public string Email { get; set; }
        
        [BsonElement("username")]
        [JsonProperty("username")]
        public string Username { get; set; }
        
        [BsonElement("given_name")]
        [JsonProperty("given_name")]
        public string GivenName { get; set; }
        
        [BsonElement("family_name")]
        [JsonProperty("family_name")]
        public string FamilyName { get; set; }
        
        [BsonElement("name")]
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [BsonElement("picture")]
        [JsonProperty("picture")]
        public string Picture { get; set; }
        
        [BsonElement("metadata")]
        [JsonProperty("metadata")]
        public UserMetaData UserMetaData { get; set; }
        
        [BsonElement("locations")]
        [JsonProperty("locations")]
        public List<string> Locations { get; set; }
    }

    public class UserMetaData
    {
        [BsonElement("favourite_color")]
        [JsonProperty("favourite_color")]
        public string FavouriteColor { get; set; }
    }
}
