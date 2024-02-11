namespace test;

public class Storage
{
    private Dictionary<int, User> _users = new Dictionary<int, User>();

    private Dictionary<int, Category> _categories = new Dictionary<int, Category>();

    private Dictionary<int, Dp> _dps = new Dictionary<int, Dp>();

    private int _userId = 1;
    
    private int _categoryId = 1;
    
    private int _dpId = 1;


    public int addUser(User user)
    {
        user.Id = _userId;
        _users.Add(_userId, user);  
        return _userId++;
    }

    public int removeUser(int userId)
    {
        _users.Remove(userId);
        return userId;
    }

    
    public int addCategory(int categoryId, Category category)
    {
        _categories.Add(categoryId, category);
        return categoryId;
    }

    public int removeCategory(int categoryId)
    {
        _categories.Remove(categoryId);
        return categoryId;
    }
    

    public int addDp(Dp dp)
    {
        _dps.Add(dp.Id, dp);
        return dp.Id;
    }

    public Dp getDp(int dpId)
    {
        return _dps[dpId];
    }

    public int removeDp(int dpId)
    {
        _dps.Remove(dpId);
        return dpId;
    }
}