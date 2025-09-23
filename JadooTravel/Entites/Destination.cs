using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace JadooTravel.Entites
{
    public class Destination
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)] // MongoDB bu filed'ı PK Olarak kullanır ve ObjectId türünde saklar.
        public string DestionationId { get; set; }
        public string CityCountry { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string DayNight { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }
    }
}
