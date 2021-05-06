using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace BooksApi.Models
{
    public class Asset
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("_id")]
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [BsonElement("validation_code")]
        [JsonProperty("validation_code")]
        public string ValidationCode { get; set; }
        
        [BsonElement("denomination")]
        [JsonProperty("denomination")]
        public string Denomination { get; set; }
        
        [BsonElement("suggested_denomination")]
        [JsonProperty("suggested_denomination")]
        public string SuggestedDenomination { get; set; }
        
        [BsonElement("asset_number")]
        [JsonProperty("asset_number")]
        public int AssetNumber { get; set; }
        
        [BsonElement("asset_sub_number")]
        [JsonProperty("asset_sub_number")]
        public int AssetSubNumber { get; set; }
        
        [BsonElement("book")]
        [JsonProperty("book")]
        public string Book { get; set; }

        [BsonElement("capitalization_date")]
        [JsonProperty("capitalization_date")]
        public string CapitalizationDate { get; set; }
        
        [BsonElement("class")]
        [JsonProperty("class")]
        public string AssetClass { get; set; }
        
        [BsonElement("initial_capital")]
        [JsonProperty("initial_capital")]
        public string InitialCapital { get; set; }
        
        [BsonElement("vcaa")]
        [JsonProperty("vcaa")]
        public string VCAA { get; set; }
        
        [BsonElement("vcan")]
        [JsonProperty("vcan")]
        public string VCAN { get; set; }
        
        [BsonElement("total")]
        [JsonProperty("total")]
        public string Total { get; set; }
        
        [BsonElement("area")]
        [JsonProperty("area")]
        public string AssetArea { get; set; }
        
        [BsonElement("line")]
        [JsonProperty("line")]
        public string AssetLine { get; set; }
        
        [BsonElement("system")]
        [JsonProperty("system")]
        public string AssetSystem { get; set; }
        
        [BsonElement("component")]
        [JsonProperty("component")]
        public string AssetComponent { get; set; }
        
        [BsonElement("ms_code")]
        [JsonProperty("ms_code")]
        public string MSCode { get; set; }
        
        [BsonElement(" conc")]
        [JsonProperty("conc")]
        public string Conc { get; set; }
        
        [BsonElement("snc")]
        [JsonProperty("snc")]
        public string SNC { get; set; }
        
        [BsonElement("status")]
        [JsonProperty("status")]
        public string Status { get; set; }
        
        [BsonElement("tour_date")]
        [JsonProperty("tour_date")]
        public string TourDate { get; set; }
        
        [BsonElement("ms_agent")]
        [JsonProperty("ms_agent")]
        public string MSAgent { get; set; }
        
        [BsonElement("ipu_agent")]
        [JsonProperty("ipu_agent")]
        public string IPUAgent { get; set; }

        [BsonElement("comments")]
        [JsonProperty("comments")]
        public string Comments { get; set; }

    }
}