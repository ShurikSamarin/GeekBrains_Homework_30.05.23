// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!"); Создать двумерный массив, на вход принять позицию элемента в массиве, возвращает зачение этого элемента или указание, что такого элемента нет

Console.WriteLine("Input rows: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Input columns: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine("Input target positions ");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
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
if (y>columns || x>rows || x<=0 || y<=0){
    Console.WriteLine("Out of range");
}
else
{
    int res = array[x-1,y-1];
    Console.WriteLine($"Your target is {res}");
}
Console.WriteLine("");
//GetArrayFindPosition(array, x, y);
void GetArrayFindPosition(int[,] arr, int row, int column)

{
    int reply = 0;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(i==row && j==column)
            {
                reply = arr[i, j];
            }
            else
            {
                reply = 0;
            }
            //Console.Write($"{array[i,j]} ");
        }
        //Console.WriteLine();
    }
    Console.WriteLine(reply);
}
