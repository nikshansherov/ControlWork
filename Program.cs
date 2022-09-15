// Данная программа принимает массив строк от пользователя,
// формирует массив из первоначального с длинами строк
// меньше или равными 3.
// Выводит оба массива на экран.

// Принимает массив строк с клавиатуры.
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

// Создает новый массив строк на основе введенного.
string[] CreateNewArray(string[] array)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) j++;
    }
    string[] newArray = new string[j];
    j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

// Выводит массив на экран.
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]}\t");
    Console.WriteLine();
}

string[] array = CreateArray();
string[] newArray = CreateNewArray(array);
Console.WriteLine("Введенный массив:");
PrintArray(array);
Console.WriteLine("Сформированный массив:");
PrintArray(newArray);