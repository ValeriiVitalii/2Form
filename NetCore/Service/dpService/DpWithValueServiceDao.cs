/*using test.utilityStaticClass;

namespace test.service.сategoryManagement.dpService;

public class DpWithValueServiceDao : IDpWithValueService
{
    private Storage _storage = new Storage();
    
    public void addDpWithValueAfterAddTask(IEnumerable<DpWithoutValue> dps, int taskId)
    {
        _storage.addDpWithValueAfterAddTask(dps, taskId);
    }

    public void editValue(int dpId, object value)
    {
        Validate.typeValidate(getDpWithValue(dpId).Type, value);
        _storage.editDpValue(dpId, value);
    }

    public DpWithValue getDpWithValue(int dpId)
    {
        return _storage.getDpWithValue(dpId);
    }

    public int removeDpWithValue(int dpId)
    {
        _storage.removeDp(dpId);
        return dpId;
    }
}*/