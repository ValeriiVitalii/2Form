using _Net.Models;
using Microsoft.EntityFrameworkCore;
using NetCore;

namespace _Net.Service.statusService;

public class StatusServiceDao : IStatusService
{
    private readonly MyDbContext _db;

    public StatusServiceDao(MyDbContext db)
    {
        _db = db;
    }
    
    public void AddStatus(Status status)
    {
        _db.Add(status);
        _db.SaveChanges();
    }

    public async Task<List<Status>> GetDefaultStatuses()
    {
        var ids= new List<int>{1,2,3};
        
        return await _db.Status
            .Where(s => ids.Contains(s.Id))
            .ToListAsync();
    }
}