// 

string[] CreateArray()
{
    Console.Write("Введите длину массива: ");
    int lenArray = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[lenArray];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] CreateNewArray(string[] array)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) j ++;         
    }
    string[] newArray = new string[j];
    j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            
            newArray[j] = array[i];
            j ++;
        }
    }
    return newArray;
}

string[] array = CreateArray();
string[] newArray = CreateNewArray(array);
