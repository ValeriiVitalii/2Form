namespace test;

internal static class Start
{
    public static void Main(string[] args)
    {
        Manager manager = new Manager();
        manager.addDp(TypeDp.file, "sss", "Test.txt");
    }
}