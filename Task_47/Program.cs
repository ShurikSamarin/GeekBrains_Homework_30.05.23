// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!"); Создать двумерный массив МхН, заполненный случайными вещественными числами
double [,] GetArray(int m, int n, double minValue, double maxValue)
{
    double [,] arr = new double[m,n];//метод заполнения мвссива вещественными числами
    Random rand = new Random();
    double range = maxValue - minValue;
    for (int i = 0; i < m; i++)
    {   
        for (int j = 0; j<n; j++){
        
        double number = rand.NextDouble();
        arr[i,j] = (number*range)+minValue;
        Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
    return arr;
}

Console.WriteLine("Input m");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Input n");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("");
double[,] array = GetArray(a,b, -99, 99);//метод создания массива

