using MongoDB.Bson.Serialization.Attributes;

namespace Portfolio.Models
{
    public class Contact
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Double PhoneNumber { get; set; }
        public string Message { get; set; }


    }
}
