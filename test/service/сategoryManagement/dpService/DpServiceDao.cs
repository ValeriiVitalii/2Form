using test.utilityStaticClass;

namespace test.dpService;

public class DpServiceDao : IDpService
{
    private Storage _storage = new Storage();
    
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

    public Dp getDp(int id)
    {
        return _storage.getDp(id);
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
}