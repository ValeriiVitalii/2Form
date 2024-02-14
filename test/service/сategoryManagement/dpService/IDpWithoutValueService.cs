namespace test.dpService;

public interface IDpWithoutValueService
{
    internal void addDpWithoutValue(TypeDp typeDp, String name);

    internal void addCatIdInDp(int dpId, List<int> catsId);

    internal int removeDpWithoutValue(int dpId);
}