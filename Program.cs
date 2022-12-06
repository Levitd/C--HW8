using System;
using static System.Console;
using System.Diagnostics;

Clear();

//Создание двумерного массива 
int[,] Get2DArray(int rows, int colums, int min, int max)
{
    int[,] result = new int[rows, colums];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}
//Печать двумерного массива
void Print2DArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j].ToString().PadLeft(5, ' ')} ");
        }
        WriteLine();
    }
}


//-------------------------------------------------------------------------
// Задача 54
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// !!! В примере показан массив упорядоченный по возрастанию !!!

/*
try
{
    Write("Введите размер массива через пробел: ");
    string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    int minElement = 0;
    int maxElement = 10;
    int[,] array = Get2DArray(Convert.ToInt32(nums[0]), Convert.ToInt32(nums[1]), minElement, maxElement);

    Print2DArray(array);
    Sort2DArray(array);

    WriteLine();
    Print2DArray(array);

}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число! ");
}
catch
{
    Write("Ошибка выполнения!");
}
void Sort2DArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            int max = inArray[i, 0];
            int index = 0;
            for (int k = 0; k < inArray.GetLength(1) - j; k++)
            {
                if (max < inArray[i, k])
                {
                    inArray[i, index] = inArray[i, k];
                    inArray[i, k] = max;
                    index = k;
                    max = inArray[i, k];
                }
                else
                {
                    index = k;
                    max = inArray[i, k];
                }

            }
        }
    }
}
*/
//-------------------------------------------------------------------------

// Задача 56
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
try
{
    Write("Введите размер массива через пробел: ");
    string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    int minElement = 0;
    int maxElement = 10;
    int[,] array = Get2DArray(Convert.ToInt32(nums[0]), Convert.ToInt32(nums[1]), minElement, maxElement);

    Print2DArray(array);
    int MinRow = GetMinRowSumArray(array);

    WriteLine($"Минимальная сумма в строке: {MinRow}");

}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число!");
}
catch
{
    Write("Ошибка выполнения!");
}
int GetMinRowSumArray(int[,] inArray)
{
    int minSum=0;
    int sumRow =0; 
    int row = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int s = 0; s < inArray.GetLength(1) - 1; s++)
        {
            sumRow += inArray[i, s];
        }
        if (minSum > sumRow || i==0) 
        {
            minSum= sumRow;
            row=i;
        }
        sumRow=0;
    }
    return row;
}
*/
//-------------------------------------------------------------------------

// Задача 58
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

/*
try
{
    Write("Введите размер массивов через пробел: ");
    string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    int minElement = 0;
    int maxElement = 10;
    int[,] array1 = Get2DArray(Convert.ToInt32(nums[0]), Convert.ToInt32(nums[1]), minElement, maxElement);
    int[,] array2 = Get2DArray(Convert.ToInt32(nums[0]), Convert.ToInt32(nums[1]), minElement, maxElement);

    WriteLine("Массив 1: ");
    Print2DArray(array1);
    WriteLine("Массив 2: ");
    Print2DArray(array2);
    WriteLine("Произведение 1 и 2 массивов: ");
    int[,] GenerationArray = GetGenerationArray(array1, array2);

    Print2DArray(GenerationArray);
    
}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число! Ввели непонять что!");
}
catch
{
    Write("Ошибка выполнения!");
}

int[,] GetGenerationArray(int[,] inArray1, int[,] inArray2)
{
    int[,] result = new int[inArray1.GetLength(0), inArray1.GetLength(1)];
    for (int i = 0; i < inArray1.GetLength(0); i++)
    {
        for (int j = 0; j < inArray1.GetLength(1); j++)
        {
            result[i,j] = inArray1[i, j] * inArray2[i, j];
        }
    }
    return result;
}
*/
//-------------------------------------------------------------------------
// Задача 60
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

/* 
try
{
    WriteLine("Создаем массив из уникальных двухзначных цисел....");
    Write("Введите размер Трехмерного массива через пробел: ");
    string[] nums = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    int minElement = 10;
    int maxElement = 99;
    int notRepeat = 1; // 1 - массив из уникальных значений, 0 - значения погут повторяться
    if (notRepeat == 1)
    {
        int countElemen = Convert.ToInt32(nums[0]) * Convert.ToInt32(nums[1]) * Convert.ToInt32(nums[2]);
        if (countElemen > (maxElement - minElement))
        {
            WriteLine("Создаваемый массив больше чем заданное кол-во уникальных элементов");
            return;
        }
    }
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();

    int[,,] array = Get3DArray(Convert.ToInt32(nums[0]), Convert.ToInt32(nums[1]), Convert.ToInt32(nums[2]), minElement, maxElement, notRepeat);

    Print3DArrayWithIndex(array);

    stopwatch.Stop();
    WriteLine();
    WriteLine($"Затраченное время: {1000L*1000L*stopwatch.ElapsedTicks/Stopwatch.Frequency}(мкс).");


}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число!");
}
catch
{
    Write("Ошибка выполнения!");
}

//Создание трехмерного массива 
int[,,] Get3DArray(int x, int y, int z, int min, int max, int notRepeat)
{
    int[,,] result = new int[x, y, z];
    string el = string.Empty;
    int foundEl = -1;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                while (true)
                {
                    result[i, j, k] = new Random().Next(min, max + 1);
                    if (notRepeat == 1)
                    {
                        foundEl = el.IndexOf(result[i, j, k].ToString());
                        if (foundEl == -1) break;
                    }
                    else break;
                }
                el += result[i, j, k].ToString() + ", ";
            }
        }
    }
    return result;
}

//Печать трехмерного массива с индексами
void Print3DArrayWithIndex(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Write($"{inArray[i, j, k].ToString().PadLeft(2, ' ')}({i},{j},{k}) ");
            }
        }
        WriteLine();
    }
}
*/
//-------------------------------------------------------------------------
// Задача 62
// Напишите программу, которая заполнит спирально массив 4 на 4.


try
{
    Write("Введите размер квадратного массива: ");
    int num = Convert.ToInt32(ReadLine());

    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();

    int[,] array = GetSpiralArray(num);

    Print2DArray(array);

    stopwatch.Stop();
    Console.WriteLine($"Затраченное время: {1000L * 1000L * stopwatch.ElapsedTicks / Stopwatch.Frequency}(мкс).");


}
catch (OverflowException)
{
    Write("Переполнение! Ввели слишком большое число!");
}
catch (FormatException)
{
    Write("Ожидалось число!");
}
catch
{
    Write("Ошибка выполнения!");
}

//Создание двумерного массива c заполнением по спирали числами начиная с 1.
int[,] GetSpiralArray(int rows)
{
    int[,] result = new int[rows, rows];
    int i = 0, j = 0;
    int number = 1;

    int minX = 0;
    int minY = 0;
    int maxX = result.GetLength(0);
    int maxY = result.GetLength(1);
    while (minX < maxX)
    {
        while (j < maxY)
        {
            result[i, j] = number;
            number++;
            j++;
        }
        j--;
        i++;
        while (i < maxX)
        {
            result[i, j] = number;
            number++;
            i++;
        }
        i--;
        j--;
        while (j >= minY)
        {
            result[i, j] = number;
            number++;
            j--;
        }
        i--;
        j++;
        while (i > minY)
        {
            result[i, j] = number;
            number++;
            i--;
        }
        i++;
        j++;
        minX++;
        minY++;
        maxX--;
        maxY--;
    }
    return result;
}

