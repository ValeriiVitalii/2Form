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
        return _storage.getDpWithoutValue(dpId);
    }

    public void addCatIdInDp(int dpId, List<int> catsId)
    {
        _storage.getDpWithoutValue(dpId).AddCatId(catsId);
    }
    public IEnumerable<DpWithoutValue> getDpByCatId(int catId) //Не оптимально выгружать List дп, с базой сделал бы по-другому
    {
        List<DpWithoutValue> dpWithoutValues = _storage.getDpsWithoutValue();
        //Нахождение дп, в которых есть передаваемый catId
        return dpWithoutValues.Where(dwv => dwv.UseCatId.Contains(catId)); //Проверить работает ли
    }

    public int removeDpWithoutValue(int dpId)
    {
        _storage.removeDp(dpId);
        return dpId;
    }
}