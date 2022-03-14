using Hotelsql.Models;

namespace Hotelsql.Repositories;

public interface IScheduleRepository
{
    Task Create(Room Item);
    Task Update(Room Item);
    Task Delete(int Id);
    Task GetList();
    Task GetById(int Id);
}

public class ScheduleRepository : BaseRepository, IScheduleRepository
{
    public ScheduleRepository(IConfiguration config) : base(config)
    {

    }
}