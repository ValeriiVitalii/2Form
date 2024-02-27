using _Net.Models.Dp;
using NetCore;

namespace _Net.Service.dpService;

public class DpWithoutValueServiceDao : IDpWithoutValueService
{
    private Storage _storage = new Storage();
    
    private readonly MyDbContext _db;
    
    public DpWithoutValueServiceDao(MyDbContext dbContext)
    {
        _db = dbContext;
    }
    
    public void addDpWithoutValue(DpWithoutValue dpWithoutValue)
    {
        _db.Add(dpWithoutValue);
        _db.SaveChanges();
    }

    public List<DpWithoutValue> GetAllDpWithoutValue()
    {
        return _db.DpWithoutValues.ToList();
    }

    /*public DpWithoutValue getDpWithoutValue(int dpId)
    {
        
    }

    public void addCatIdInDp(int dpId, List<int> catsId)
    {
    }
    public IEnumerable<DpWithoutValue> getDpByCatId(int catId) //Не оптимально выгружать List дп, с базой сделал бы по-другому
    {
        List<DpWithoutValue> dpWithoutValues = _storage.getDpsWithoutValue();
        //Нахождение дп, в которых есть передаваемый catId
        return dpWithoutValues.Where(dwv => dwv.UseCatId.Contains(catId)); //Проверить работает ли
    }

    public int removeDpWithoutValue(int dpId)
    {
     
    }*/
}