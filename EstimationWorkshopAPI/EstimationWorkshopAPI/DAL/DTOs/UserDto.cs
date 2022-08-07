using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace EstimationWorkshopAPI.DAL.DTOs;

public class UserDto
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public string Email { get; set; } = null!;
    
    public string Password { get; set; } = null!;
}