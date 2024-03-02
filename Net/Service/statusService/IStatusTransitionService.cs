namespace _Net.Service.statusService;

public interface IStatusTransitionService
{
    internal void AddTransition(StatusTransition statusTransition);

    internal Task AddDefaultTransition(int catId);
}