using _Net.Models;

namespace _Net.Service.statusService;

public interface IStatusService
{
    internal void AddStatus(Status status);
    internal Task<List<Status>> GetDefaultStatuses();
}