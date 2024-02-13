namespace test.dpService;

public interface IDpService
{
    internal void addDp(TypeDp typeDp, String name, object value);

    internal void addCatIdInDp(int dpId, List<int> catsId);

    internal int removeDp(int dpId);
}