namespace test.service.сategoryManagement;

public interface IStatusService
{
    internal int createStatus(string name, bool isTerminal);

    internal Status getStatus(int idStatus);
}