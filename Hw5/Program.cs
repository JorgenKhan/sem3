//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int [] newArray = new int [size];

    for (int i=0; i<size; i++)
        newArray[i]=new Random().Next(minValue, maxValue +1);
    return newArray;
}

void ShowArray(int [] array)
{
    for (int i=0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int minValue = 100;
int maxValue = 999;
int CountEvenNumbers(int [] array, int minValue, int maxValue)
{
    int count = 0;
    for (int i=0; i<array.Length; i++)
        if(array[i]%2==0) count++;
    return count;
}

int [] newArray = CreateRandomArray(10, 100, 999);
ShowArray(newArray);
int count = CountEvenNumbers(newArray, minValue, maxValue);
Console.WriteLine($"Внутри массива содержится {count} четных элементов");*/

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int [] newArray = new int [size];

    for (int i=0; i<size; i++)
        newArray[i]=new Random().Next(minValue, maxValue +1);
    return newArray;
}

void ShowArray(int [] array)
{
    for (int i=0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int SumOddNumbers(int [] array)
{
    int sum = 0;
    for (int i=0; i<array.Length; i+=2)
        sum = sum + array[i];
    return sum;
}

int [] myArray = CreateRandomArray(5, -100, 100);
ShowArray(myArray);
int res = SumOddNumbers(myArray);
Console.WriteLine($"Sum of odd position elements is {res}");*/

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateArray(int size)
{
    double[] array = new double[size];
    Console.WriteLine("Creating array: ");
    for (int i=0; i<size; i++)
    {
        Console.Write($"Input a {i+1} element of array: ");
        array[i] = Convert.ToUInt32(Console.ReadLine());
    }
     Console.WriteLine("Completed!");
     return array;
}

void ShowArray(double[] array)
{
    for (int i=0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

double DifferenceBtwMaxAndMin(double[] array)
{
      double diff = 0;
    double max = array[0];
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
            min = array[i];
        if(array[i] > max)
            max = array[i];
    }
    diff = max - min;
    return diff;
}
Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateArray(size);
ShowArray(myArray);
double res = DifferenceBtwMaxAndMin(myArray);
Console.WriteLine(res);