using EstimationWorkshopAPI.DAL.DTOs;
using EstimationWorkshopAPI.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace EstimationWorkshopAPI.DAL;

public class UserService
{
    private readonly IMongoCollection<UserDto> _userCollection;

    public UserService(IOptions<AppDatabaseSetting> dbSettings)
    {
        var mongoClient = new MongoClient(dbSettings.Value.ConnectionString);
        var mongoDatabase = mongoClient.GetDatabase(dbSettings.Value.DatabaseName);
        _userCollection = mongoDatabase.GetCollection<UserDto>(dbSettings.Value.UserCollectionName);
    }
    
    public async Task<List<UserDto>> GetAsync() => 
        await _userCollection.Find(_ => true).ToListAsync();

    public async Task<UserDto?> GetAsync(string id) =>
        await _userCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

    public async Task CreateAsync(UserDto newUser) =>
        await _userCollection.InsertOneAsync(newUser);

    public async Task UpdateAsync(string id, UserDto updatedUser) =>
        await _userCollection.ReplaceOneAsync(x => x.Id == id, updatedUser);

    public async Task RemoveAsync(string id) =>
        await _userCollection.DeleteOneAsync(x => x.Id == id);
}