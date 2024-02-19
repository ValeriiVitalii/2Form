using NetCore.Models;

namespace test;

public class Storage
{
    private Dictionary<int, Category> _categories = new Dictionary<int, Category>();
    
    private int _categoryId = 1;

    
    public int AddCategory(Category category)
    {
        category.Id = _categoryId;
        _categories.Add(_categoryId, category);
        return _categoryId++;
    }

    public Category getCategory(int id)
    {
        return _categories[id];
    }

    public int RemoveCategory(int categoryId)
    {
        _categories.Remove(categoryId);
        return categoryId;
    }
    

    /*public int addDpWithoutValue(DpWithoutValue dpWithoutValue)
    {
        dpWithoutValue.Id = _dpWithoutValueId;
        _dpsWithoutValue.Add(_dpWithoutValueId, dpWithoutValue);
        return _dpWithoutValueId++;
    }

    public DpWithoutValue getDpWithoutValue(int dpId)
    {
        return _dpsWithoutValue[dpId];
    }
    
    public List<DpWithoutValue> getDpsWithoutValue()
    {
        return _dpsWithoutValue.Values.ToList();
    }
    
    public DpWithValue getDpWithValue(int dpId)
    {
        return _dpsWithValue[dpId];
    }
    
    public int addDpWithValue(DpWithValue dpWithValue)
    {
        dpWithValue.Id = _dpWithValueId; 
        _dpsWithValue.Add(_dpWithValueId, dpWithValue);
        return _dpWithValueId++;
    }
    
    public void addDpWithValueAfterAddTask(IEnumerable<DpWithoutValue> dps, int taskId)
    {   //Сделал в storage потому что тут логика заполнения id
        dps.ToList().ForEach(dp => _dpsWithValue.Add(_dpWithValueId++, Mapper.toDpWithValue(dp, taskId)));
    }

    public int editDpValue(int dpId, object value)
    {
        _dpsWithValue[dpId].Value = value;
        return dpId;
    }

    public int removeDp(int dpId)
    {
        _dpsWithoutValue.Remove(dpId);
        return dpId;
    }*/
}