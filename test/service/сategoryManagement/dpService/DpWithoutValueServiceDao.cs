using test.dpService;

namespace test.service.сategoryManagement.dpService;

public class DpWithoutValueServiceDao : IDpWithoutValueService
{
    private Storage _storage = new Storage();
    
    public void addDpWithoutValue(TypeDp typeDp, String name)
    {
        DpWithoutValue dp = new DpWithoutValue(typeDp, name);
        _storage.addDpWithoutValue(dp);
    }

    public DpWithoutValue getDpWithoutValue(int dpId)
    {
        return _storage.getDp(dpId);
    }

    public void addCatIdInDp(int dpId, List<int> catsId)
    {
        _storage.getDp(dpId).AddCatId(catsId);
    }

    public int removeDpWithoutValue(int dpId)
    {
        _storage.removeDp(dpId);
        return dpId;
    }
}