// Задаем первоначальный массив.
string[] array1 = new string[] {"qwerty", "123", "йцукенг", "Hello", "world", ":-)"};

// Объявляем конечный массив.
string[] array2 = new string[array1.Length];

// Метод формирования конечного массива (строки с длиной меньше или равной 3 символам).
void SecondArrayForm (string[] array1, string[] array2)
{
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length < 4)
        {
        array2[j] = array1[i];
        j++;
        }
    }
}

// Метод вывода массива в консоль.
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} "); // Выводим очередной элемент массива.
    }
    Console.WriteLine();
}

SecondArrayForm(array1, array2); // Вызываем метод формирования конечного массива.
Console.WriteLine("Первоначальный массив:");
PrintArray(array1); // Вызываем метод вывода массива в консоль.
Console.WriteLine("Конечный массив:");
PrintArray(array2); // Вызываем метод вывода массива в консоль.
