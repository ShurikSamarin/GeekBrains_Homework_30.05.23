// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!"); Задать двумерный массив из целых чисел. Вывести средние арифметические в каждом столбце
Console.WriteLine("Input rows: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Input columns: ");
int columns = int.Parse(Console.ReadLine());
int[,] GetArray(int rows, int columns,int minValue,int maxValue)
{
    int[,] result = new int[rows, columns];
    for(int i =0;i < rows;i++)
    {
        for (int j = 0; j < columns;j++)
        {
            result[i, j] = new Random().Next(minValue,maxValue);
            Console.Write($"{result[i,j]} ");
        }
        Console.WriteLine();
    }
    return result;
}
Console.WriteLine("");
Console.WriteLine("Array: ");
int[,] array = GetArray(rows, columns,1,10);
Console.WriteLine("");
Console.WriteLine("Average sums of columns are:");
void AverageSum(int[,] arr)
{
    for(int i =0;i < arr.GetLength(1);i++)
    {
        double result = 0;
        for (int j = 0; j < arr.GetLength(0);j++)
        {
            result = result + arr[j,i];
        }
        result = result/arr.GetLength(0);
        Console.Write("{0:F2}  ", (result));
    }
    Console.WriteLine("");
}
AverageSum(array);