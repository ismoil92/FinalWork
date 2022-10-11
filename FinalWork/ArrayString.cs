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
}