
/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

/*
int [,] Create2dRandomArray (int rows, int cols, int min, int max)
{
    int [,] array = new int [rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
        array [i,j] = new Random().Next(min, max+1);
        }
    }
    return array;
}

void Show2dArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

int [,] StringNumbers (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int j1 = 0; j1 < array.GetLength(1) - 1; j1++)
            {
                if (array [i,j1] < array [i,j1+1])
                {
                    int temp = array[i,j1];
                    array[i,j1] = array[i,j1+1];
                    array[i,j1+1] = temp;
                }
            }
        }
    }
    return array;
}

Console.Write("Input rows numb: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input columns numb: ");
int cols = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min numb: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max numb: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] array = Create2dRandomArray(rows, cols, min, max);
Show2dArray(array);
Console.WriteLine();
int [,] changed_array = StringNumbers(array);
Show2dArray(changed_array);

*/


/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

/*
int [,] Create2dRandomArray (int rows, int cols, int min, int max)
{
        int [,] array = new int [rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
            array [i,j] = new Random().Next(min, max+1);
            }
        }
    return array;
}

void Show2dArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

void SummNumbers (int [,] array, int rows)
{
    int [] summNum = new int [rows];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ = summ + array[i,j];
        }
        summNum[i] = summ;
    }

    int min = summNum[0];
    int numMin = 0;
    for (int i = 0; i < summNum.Length; i++)
    {
        if(summNum[i] < min)
        {
            min = summNum[i];
            numMin = i;
        }
    } 
    Console.WriteLine($"Number of row with min summ: {numMin+1} row"); 
}

Console.Write("Input rows numb: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input columns numb: ");
int cols = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min numb: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max numb: ");
int max = Convert.ToInt32(Console.ReadLine());

if(rows < cols || rows > cols)
{
int [,] array = Create2dRandomArray(rows, cols, min, max);
Show2dArray(array);
Console.WriteLine();
SummNumbers(array, rows);
}

else
{
    Console.WriteLine("Impossible value");
    int [,] array = Create2dRandomArray(rows, cols, min, max);
}

*/

/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

/*
int [,] Create2dRandomArray1 (int min, int max)
{
        int [,] array = new int [2, 2];
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
            array [i,j] = new Random().Next(min, max+1);
            }
        }
    return array;
}

int [,] Create2dRandomArray2 (int min, int max)
{
        int [,] array = new int [2, 2];
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
            array [i,j] = new Random().Next(min, max+1);
            }
        }
    return array;
}

void ShowArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

int [,] SumMatrix (int [,] array1, int [,] array2)
{
    int [,] array = new int [2, 2];
    array [0,1] = array1[0,0] * array2[0,1] + array1[0,1]*array2[1,1];
    array [0,0] = array1[0,0] * array2[0,0] + array1[0,1]*array2[1,0];
    array [1,0] = array1[1,0] * array2[0,0] + array1[1,1]*array2[1,0];
    array [1,1] = array1[1,0] * array2[0,1] + array1[1,1]*array2[1,1];
    return array;
}

Console.Write("Input min numb: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max numb: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] array1 = Create2dRandomArray1(min, max);
ShowArray(array1);
Console.WriteLine();

int [,] array2 = Create2dRandomArray2(min, max);
ShowArray(array2);
Console.WriteLine();

int [,] multiple_array = SumMatrix(array1, array2);
ShowArray(multiple_array);

*/


/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

/*
int [,,] Create3dRandomArray ()
{
    int min = 10;
    int max = 99;
    int rows = 2;
    int cols = 2;
    int deep = 2;
    int [] newarray = new int [8];
    int i1 = 0;
    int [,,] array = new int [rows, cols, deep];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int k = 0; k < deep; k++)
            {
                int element = new Random().Next(min, max+1);
                while(CheckArray(newarray, element))
                {
                    element = new Random().Next(min, max+1);
                }    
                array [i,j,k] = element;
                newarray[i1] = element;
                i1++;
            }
        }
    }
    return array;
}

bool CheckArray(int [] array, int element)
{
    bool not_unique = false;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == element)
        {
            not_unique = true;
        }
    }
    return not_unique;
}

void Show3dArray(int [,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
            Console.Write($"{array[i,j,k]} ({i},{j},{k}) ");
            } 
            Console.WriteLine();
        }
    }
}

int [,,] array = Create3dRandomArray();
Show3dArray(array);
Console.WriteLine();

*/

/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

/*
int i1 = 0;
int i2 = 3;
int j1 = 0;
int j2 = 3;
int num = 0;
int [,] array = new int [4,4];

while((j1<j2)&&(i1<i2)) 
{
  for (int j = j1; j <= j2; j++)
    {
        array [i1,j] = num + 1;
        num++;
    }
    i1++;
    for (int i = i1; i <= i2; i++)
        {
            array [i,j2] = num + 1;
            num++;
        }
        j2--;
        for (int j = j2; j >= j1; j--)
            {
                array [i2,j] = num + 1;
                num++;
            }
            i2--;
            for (int i = i2; i >= i1; i--)
                {
                array [i,j1] = num + 1;
                num++;
                }
                j1++;
}

void ShowArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+ " ");
        }
        Console.WriteLine();
    }
}

ShowArray(array);
*/