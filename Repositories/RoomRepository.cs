using Dapper;
using Hotelsql.Models;
using Hotelsql.Utilities;

namespace Hotelsql.Repositories;

public interface IRoomRepository
{
    Task Create(Room Item);
    Task Update(Room Item);
    Task Delete(int Id);
    Task GetList();
    Task<Room> GetById(int Id);
    Task<List<Room>> GetListByGuestId(int GuestId);
}

public class RoomRepository : BaseRepository, IRoomRepository
{
    public RoomRepository(IConfiguration config) : base(config)
    {

    }

    public Task Create(Room Item)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int Id)
    {
        throw new NotImplementedException();
    }

    public async Task<Room> GetById(int Id)
    {
        var query = $@"SELECT r.*, s.name AS staff_name FROM {TableNames.room} r
        LEFT JOIN {TableNames.staff} s ON s.id = r.staff_id 
        WHERE r.id = @Id";

        using (var con = NewConnection)
            return await con.QuerySingleOrDefaultAsync<Room>(query, new { Id });
    }

    public Task GetList()
    {
        throw new NotImplementedException();
    }

    public async Task<List<Room>> GetListByGuestId(int GuestId)
    {
        var query = $@"SELECT r.* FROM {TableNames.schedule} s 
        LEFT JOIN {TableNames.room} r ON r.id = s.room_id 
        WHERE s.guest_id = @GuestId";

        // LEFT JOIN {TableNames.guest} g ON g.id = s.guest_id 

        using (var con = NewConnection)
            return (await con.QueryAsync<Room>(query, new { GuestId })).AsList();
    }

    public Task Update(Room Item)
    {
        throw new NotImplementedException();
    }
}