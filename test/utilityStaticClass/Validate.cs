using System.ComponentModel.DataAnnotations;

namespace test.utilityStaticClass;

public static class Validate
{
    public static void typeValidate(TypeDp type, object value)
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