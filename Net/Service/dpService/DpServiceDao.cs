using _Net.Models.Dp;
using NetCore;

namespace _Net.Service.dpService;

public class DpServiceDao : IDpService
{
    private Storage _storage = new Storage();
    
    private readonly MyDbContext _db;
    
    public DpServiceDao(MyDbContext dbContext)
    {
        _db = dbContext;
    }
    
    public async Task AddDp(Dp dp)
    {
        _db.Add(dp);
        await _db.SaveChangesAsync();
    }

    public List<Dp> GetAllDp()
    {
        return _db.Dp.ToList();
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