﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace JadooTravel.Entites
{
    public class TripPlan
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string TripPlanId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
    }
}
