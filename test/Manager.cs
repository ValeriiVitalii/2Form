using System.ComponentModel.DataAnnotations;

namespace test;

public class Manager
{
    private Storage _storage = new Storage();


    public int AddUser(String name, String login, String password)
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
        typeValidate(typeDp, value);
        
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

    private void typeValidate(TypeDp type, object value)
    {
        if (type == TypeDp.text)
        {
            if (value is not String)
            {
                throw new ValidationException("В текстовом дп доступен только текст");
            }
        }
        if (type == TypeDp.numeric)
        {
            if (value is not Int32)
            {
                throw new ValidationException(
                    "В числовом дп доступны только числа от -2 147 483 648 до 2 147 483 647");
            }
        }
        if (type == TypeDp.file)
        {
            if (value is not String || !Convert.ToString(value).Contains(".txt")) // ПРОВЕРИТЬ РАБОТАЕТ ЛИ
            {
                throw new ValidationException("В файловом дп доступны только файлы с расширением .txt");
            }
        }
    }
}