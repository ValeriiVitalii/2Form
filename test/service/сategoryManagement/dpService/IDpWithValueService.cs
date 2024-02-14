namespace test.service.сategoryManagement.dpService;

public interface IDpWithValueService
{
    internal void addDpWithValue(TypeDp typeDp, String name, object value, int taskId);

    internal int removeDpWithValue(int dpId);
}