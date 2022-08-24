// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[] ReadInputArray ()
{
    int count = 0;
    double[] array = new double[4];
    for (int i = 0; i < 2; i++)
    {
        Console.WriteLine($"Введите значение b{i + 1}: ");
        array[count] = Convert.ToDouble(Console.ReadLine());
        count++;
        Console.WriteLine($"Введите значение k{i + 1}: ");
        array[count] = Convert.ToDouble(Console.ReadLine());
        count++;
    }
    Console.WriteLine();
    return array;
}

void CrossPoint (double[] arr)
{
    double b1 = arr[0];
    double k1 = arr[1];
    double b2 = arr[2];
    double k2 = arr[3];
    if (k1!= k2)
    {
        double y = (k2 * b1 - b2 * k1) / (k2 - k1);
        double x = (y - b1) / k1;
        Console.WriteLine("Координаты точки пересечения:");
        Console.WriteLine($"y = {Math.Round(y, 1)}");
        Console.WriteLine($"x = {Math.Round(x, 1)}");
    }
    else Console.WriteLine("Линии не пересекаются.");
}

double[] array = ReadInputArray();
CrossPoint(array);
