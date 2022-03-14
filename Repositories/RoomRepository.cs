using Hotelsql.Models;

namespace Hotelsql.Repositories;

public interface IRoomRepository
{
    Task Create(Room Item);
    Task Update(Room Item);
    Task Delete(int Id);
    Task GetList();
    Task GetById(int Id);
}

public class RoomRepository : BaseRepository, IRoomRepository
{
    public RoomRepository(IConfiguration config) : base(config)
    {

    }
}