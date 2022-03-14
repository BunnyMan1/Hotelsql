using Hotelsql.Models;

namespace Hotelsql.Repositories;

public interface IGuestRepository
{
    Task Create(Room Item);
    Task Update(Room Item);
    Task Delete(int Id);
    Task GetList();
    Task GetById(int Id);
}

public class GuestRepository : BaseRepository, IGuestRepository
{
    public GuestRepository(IConfiguration config) : base(config)
    {

    }
}