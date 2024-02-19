namespace test.service.сategoryManagement;

public class StatusServiceDao : IStatusService
{
    private Storage _storage = new Storage();
    
    public int createStatus(string name, bool isTerminal)
    {
        Status status = new Status(name, isTerminal);
        return _storage.createStatus(status);
    }

    public Status getStatus(int idStatus)
    {
        return _storage.getStatus(idStatus);
    }
}