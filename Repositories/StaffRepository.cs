using Hotelsql.Models;

namespace Hotelsql.Repositories;

public interface IStaffRepository
{
    Task Create(Room Item);
    Task Update(Room Item);
    Task Delete(int Id);
    Task GetList();
    Task GetById(int Id);
}

public class StaffRepository : BaseRepository, IStaffRepository
{
    public StaffRepository(IConfiguration config) : base(config)
    {

    }
}