// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int[] ReadInputArray ()
{
    Console.WriteLine("Введите желаемое количество чисел: ");
    int count = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[count];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return array;
}

void Above0 (int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    Console.WriteLine($"Введено {count} чисел больше нуля.");
}

int[] array = ReadInputArray();
Console.Write("Введенные числа: ");
Console.WriteLine(string.Join(",", array));
Console.WriteLine();
Above0(array);
