using SQLite;
using TravelSystem.Shared.Models;

namespace TravelSystem.Mobile.Services;

public class DatabaseService
{
    private const string DB_NAME = "travelsystem_offline.db3";
    private readonly SQLiteAsyncConnection _connection;

    public DatabaseService()
    {
        _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));
        _connection.CreateTableAsync<Tour>().Wait();
    }

    public async Task<List<Tour>> GetToursAsync()
    {
        return await _connection.Table<Tour>().ToListAsync();
    }

    public async Task<int> SaveTourAsync(Tour tour)
    {
        return await _connection.InsertAsync(tour);
    }
    
    public async Task<int> SaveToursAsync(IEnumerable<Tour> tours)
    {
        return await _connection.InsertAllAsync(tours);
    }
    
    public async Task<int> DeleteAllToursAsync()
    {
        return await _connection.DeleteAllAsync<Tour>();
    }
}
