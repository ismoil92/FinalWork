namespace FinalWork;

public class ArrayString
{
    /// <summary>
    /// Нахождение размер нового массива строк
    /// </summary>
    /// <param name="arrays">массив строк</param>
    /// <returns>возвращает размер массива</returns>
    public static int FindSizeArray(string[] arrays)
    {
        int size = 0;

        for (int i = 0; i < arrays.Length; i++)
        {
            if (arrays[i].Length <= 3)
                size++;
        }
        return size;
    }

    /// <summary>
    /// Создание нового массива строк
    /// </summary>
    /// <param name="oldArray">старый массив строк</param>
    /// <param name="newArray">новый массив строк</param>
    /// <returns>возвращает новый массив строк</returns>
    public static string[] CreateArray(string[] oldArray, string[] newArray)
    {
        int j = 0;
        for (int i = 0; i < oldArray.Length; i++)
        {
            if (oldArray[i].Length <= 3)
            {
                newArray[j] = oldArray[i];
                j++;
            }
        }

        return newArray;
    }
}