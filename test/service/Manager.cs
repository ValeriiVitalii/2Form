/*using System.ComponentModel.DataAnnotations;
using test.utilityStaticClass;

namespace test;

public class Manager
{
    private Storage _storage = new Storage();


    public int addUser(String name, String login, String password)
    {
        var user = new User(name, login, password);

        return _storage.addUser(user);
    }

    public int removeUser(int userId)
    {
        return _storage.removeUser(userId);
    }


    public int addCategory(int categoryId, Category category)
    {
        _storage.addCategory(categoryId, category);
        return categoryId;
    }

    public int removeCategory(int categoryId)
    {
        _storage.removeCategory(categoryId);
        return categoryId;
    }


    public void addDp(TypeDp typeDp, String name, object value)
    {
        Validate.typeValidate(typeDp, value);
        
        if (typeDp == TypeDp.text)
        {
            DpText dp = new DpText(typeDp, name, Convert.ToString(value));
            _storage.addDp(dp);
        }
        if (typeDp == TypeDp.numeric)
        {
            DpNumeric dp = new DpNumeric(typeDp, name, Convert.ToInt32(value));
            _storage.addDp(dp);
        }
        if (typeDp == TypeDp.file)
        {
            DpFile dp = new DpFile(typeDp, name, File.ReadAllLines(Convert.ToString(value)));
            
            _storage.addDp(dp);
        }
    }

    public void addCatIdInDp(int dpId, List<int> catsId)
    {
        _storage.getDp(dpId).AddCatId(catsId);
    }

    public int removeDp(int dpId)
    {
        _storage.removeDp(dpId);
        return dpId;
    }
}*/