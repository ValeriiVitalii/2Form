using NetCore;

namespace _Net.Service.statusService;

public class StatusTransitionServiceDao : IStatusTransitionService
{
    private readonly MyDbContext _db;
    
    public StatusTransitionServiceDao(MyDbContext db)
    {
        _db = db;
    }

    public void AddTransition(StatusTransition statusTransition)
    {
        _db.Add(statusTransition);
        _db.SaveChanges();
    }
    
    public async Task AddDefaultTransition(int catId)
    {
        int newStatus = 1;
        int inWorkStatus = 2;
        int completedStatus = 3;

        List<StatusTransition> statusTransitions = new List<StatusTransition>
        {
            new StatusTransition(newStatus, inWorkStatus, catId),
            new StatusTransition(inWorkStatus, newStatus, catId), //Обратный переход
            new StatusTransition(inWorkStatus, completedStatus, catId),
            new StatusTransition(completedStatus, inWorkStatus, catId) //Обратный переход
        };

        await _db.AddRangeAsync(statusTransitions);
        await _db.SaveChangesAsync();
    }
}