using Dapper;
using Hotelsql.Models;
using Hotelsql.Utilities;

namespace Hotelsql.Repositories;

public interface IScheduleRepository
{
    Task Create(Schedule Item);
    Task Update(Schedule Item);
    Task Delete(int Id);
    Task GetList();
    Task GetById(int Id);
    Task<List<Schedule>> GetListByGuestId(int GuestId);
}

public class ScheduleRepository : BaseRepository, IScheduleRepository
{
    public ScheduleRepository(IConfiguration config) : base(config)
    {

    }

    public Task Create(Schedule Item)
    {
        throw new NotImplementedException();
    }

    public Task Delete(int Id)
    {
        throw new NotImplementedException();
    }

    public Task GetById(int Id)
    {
        throw new NotImplementedException();
    }

    public Task GetList()
    {
        throw new NotImplementedException();
    }

    public async Task<List<Schedule>> GetListByGuestId(int GuestId)
    {
        var query = $@"SELECT * FROM {TableNames.schedule} 
        WHERE guest_id = @GuestId";

        using (var con = NewConnection)
            return (await con.QueryAsync<Schedule>(query, new { GuestId })).AsList();
    }

    public Task Update(Schedule Item)
    {
        throw new NotImplementedException();
    }
}