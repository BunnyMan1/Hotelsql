using Hotelsql.Models;

namespace Hotelsql.Repositories;

public interface IStaffRepository
{
    Task Create(Staff Item);
    Task Update(Staff Item);
    Task Delete(int Id);
    Task GetList();
    Task GetById(int Id);
}

public class StaffRepository : BaseRepository, IStaffRepository
{
    public StaffRepository(IConfiguration config) : base(config)
    {

    }

    public Task Create(Staff Item)
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

    public Task Update(Staff Item)
    {
        throw new NotImplementedException();
    }
}