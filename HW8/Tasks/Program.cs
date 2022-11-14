//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] Create2Array()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Print2Array(int[,] array)

{
    Console.WriteLine("New array: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

int[,] ChangeOrderElementsRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > array[i, j])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, j];
                    array[i, j] = temp;
                }
            }
        }
    }
    return array;
}

int[,] newArray = Create2Array();
Print2Array(newArray);
Console.WriteLine();
int[,] changeArray = ChangeOrderElementsRows(newArray);
Print2Array(changeArray); */

 // Задайте прямоугольный двумерный массив.Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
 int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns]; 
    for( int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
            Console.WriteLine();
    }
}
int [] FindRowsSum (int[,] array)
{   
    int sum = 0;
    int[] newArray = new int[array.GetLength(0)]; 
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j]; 
        }
        newArray[i] = sum; 
        sum = 0;
    }
    return newArray;
}
int FindMax(int[] array)
{
    int min = array[0];
    int indexMin = 0;
    
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < min) indexMin = i + 1;
    }
    return indexMin; 
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    
        Console.Write($"Row {i + 1}: {array[i]} \n");   
    Console.WriteLine();
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine();
int [] newArray = FindRowsSum(myArray);
Console.WriteLine("Row-by-row sum of elements: ");
ShowArray(newArray);
Console.WriteLine($"The minimum sum of elements is in a row number: ");
Console.WriteLine(FindMax(newArray)); */

//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2


int[,,] CreateRandom3dArray(int rows, int columns, int indexk)
{
    int[,,] array = new int[rows, columns, indexk]; 
    int[] temp = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
    int  number;
    for (int n = 0; n < temp.GetLength(0); n++)
    {
        temp[n] = new Random().Next(10, 100);
        number = temp[n];
        if (n >= 1)
        {
            for (int m = 0; m < n; m++)
            {
                while (temp[n] == temp[m])
                {
                temp[n] = new Random().Next(10, 100);
                m = 0;
                number = temp[n];
                }
                number = temp[n];
            }
        }
    }
    int count = 0; 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = temp[count];
                count++;
            }
        }
    }
    return array;
}
void Show3dArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            {
                for(int k = 0; k < array.GetLength(2); k++)
                {
                    Console.Write($"{array[i,j,k]} ({i}, {j}, {k})" + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
}
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of elements for 3D: ");
int indexk = Convert.ToInt32(Console.ReadLine());
    if(rows * columns * indexk > 90) 
        Console.Write("The maximum possible number of non-repeating array elements has been exceeded. Array creation is not possible. ");
int[,,] myArray = CreateRandom3dArray(rows, columns, indexk);
Show3dArray(myArray);