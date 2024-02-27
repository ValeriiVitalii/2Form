using _Net.Models.Dp;

namespace _Net.Service.dpService;

public interface IDpWithoutValueService
{
    public void addDpWithoutValue(DpWithoutValue dpWithoutValue);

    public List<DpWithoutValue> GetAllDpWithoutValue();

    /*internal void addCatIdInDp(int dpId, List<int> catsId);

    internal IEnumerable<DpWithoutValue> getDpByCatId(int catId);

    internal int removeDpWithoutValue(int dpId);*/
}