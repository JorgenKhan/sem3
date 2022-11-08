// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int NumberOfPositiveElements(int num)
{
    int current = 1;
    int count = 0;
    while(current <= num) current++;
     count++;
        
    return count;
}

Console.WriteLine("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of elements: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Number of positive elements is: {NumberOfPositiveElements(num)}");
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


double [] Intersection(double b1, double k1, double b2, double k2)
{
    double x = Math.Round((b2 - b1) / (k1 - k2), 2);
    double y = Math.Round(k2 * ((b2 - b1) / (k1 - k2)) + b2, 2);
    double[] array = {x, y};
  
    return array;
}
Console.Write("Input a b-parameter for first line: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a k-parameter for first line: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a b-parameter for second line: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a k-parameter for second line: ");
double k2 = Convert.ToDouble(Console.ReadLine());

if(k1 != k2)
{
    double[] coordinate = Intersection(b1, k1, b2, k2);
    Console.WriteLine($"Coordinate of the point of intersection are: ({coordinate[0]}; {coordinate[1]})");
}
else
{
    Console.WriteLine($"Your lines are parallel");
}