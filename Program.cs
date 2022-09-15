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
