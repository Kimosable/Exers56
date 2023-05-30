// Задача 56: Задайте прямоугольный двумерный массив. Напишите 
// программу, которая будет находить строку с наименьшей суммой элементов.

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] arr = new int[rows, cols];

        Random rnd = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                arr[i, j] = rnd.Next(1, 100);
            }
        }

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("{0,4}", arr[i, j]);
            }
            Console.WriteLine();
        }

        int minSumRow = 0;
        int minSum = int.MaxValue;

        for (int i = 0; i < rows; i++)
        {
            int rowSum = 0;

            for (int j = 0; j < cols; j++)
            {
                rowSum += arr[i, j];
            }

            if (rowSum < minSum)
            {
                minSum = rowSum;
                minSumRow = i;
            }
        }

        Console.WriteLine("Строка с наименьшей суммой элементов:");
        for (int j = 0; j < cols; j++)
        {
            Console.Write("{0,4}", arr[minSumRow, j]);
        }
        Console.WriteLine();

        Console.ReadLine();
    }
}