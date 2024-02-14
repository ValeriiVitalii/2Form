using test.utilityStaticClass;

namespace test.service.сategoryManagement.dpService;

public class DpWithValueServiceDao : IDpWithValueService
{
    private Storage _storage = new Storage();
    
    public void addDpWithValue(TypeDp typeDp, String name, object value, int taskId)
    {
        Validate.typeValidate(typeDp, value);
        
        DpWithValue dp = new DpWithValue(typeDp, name, value, taskId);
        _storage.addDpWithValue(dp);
    }

    public DpWithoutValue getDpWithValue(int dpId)
    {
        return _storage.getDp(dpId);
    }

    public int removeDpWithValue(int dpId)
    {
        _storage.removeDp(dpId);
        return dpId;
    }
}