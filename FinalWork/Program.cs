using FinalWork;

string[] arrays = new string[] { "hello", "2", "world", ":-)" };
int size = ArrayString.FindSizeArray(arrays);
if (size > 0)
{
    string[] newArray = new string[size];
    newArray = ArrayString.CreateArray(arrays, newArray);

    Console.Write("Первая строка:");
    for (int i = 0; i < newArray.Length; i++)
        Console.Write(newArray[i] + ", ");
    Console.WriteLine();
}
else
    Console.WriteLine("Размер массива не существует");
Console.WriteLine();
string[] arrays2 = new string[] { "1234", "1567", "-2", "computer science" };
int size2 = ArrayString.FindSizeArray(arrays2);
if (size2 > 0)
{
    string[] newArray2 = new string[size2];
    newArray2 = ArrayString.CreateArray(arrays2, newArray2);
    Console.Write("Вторая строка:");
    for (int i = 0; i < newArray2.Length; i++)
        Console.Write(newArray2[i] + ", ");
    Console.WriteLine();
}
else
    Console.WriteLine("Размер массива не существует");
Console.WriteLine();
string[] arrays3 = new string[] { "Russian", "Denmark", "Kazan" };
int size3 = ArrayString.FindSizeArray(arrays3);
if (size3 > 0)
{
    string[] newArray3 = new string[size3];
    newArray3 = ArrayString.CreateArray(arrays3, newArray3);
    Console.Write("Первая строка:");
    for (int i = 0; i < newArray3.Length; i++)
        Console.Write(newArray3[i] + ", ");
    Console.WriteLine();
}
else
    Console.WriteLine("Размер массива не существует");