namespace test.utilityStaticClass;
using Omu.ValueInjecter;

public class Mapper
{
    public static TaskDto toTaskDto(Task task)
    {
        TaskDto taskDto = new TaskDto(
            task.Name,
            task.Description,
            task.Status);
        taskDto.Id = task.Id;
        return taskDto;
    }
    
    //Вызывается после создания задачи, когда ещё нет value
    public static DpWithValue toDpWithValue(DpWithoutValue dpWithoutValue, int taskId)
    {
        DpWithValue dpWithValue = new DpWithValue(
            dpWithoutValue.Type,
            dpWithoutValue.Name);            
        return dpWithValue;
    }
    
    public static DpWithValue toDpWithValue(DpWithoutValue dpWithoutValue, object value)
    {
        Validate.typeValidate(dpWithoutValue.Type, value);
        
        DpWithValue dpWithValue = new DpWithValue(
            dpWithoutValue.Type,
            dpWithoutValue.Name);
        dpWithValue.Value = value;
        return dpWithValue;
    }
}