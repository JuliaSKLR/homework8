//Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int[,] CreateMatrix(int rows, int columns)
{
    int[,] answer = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            answer[i, j] = rnd.Next(-10, 10);
        }

    }
    return answer;
}

void PrintMatrix(int[,] array, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] SumRows(int[,] array)
{   
    int []sumelements = new int [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        
                sumelements[i] = array[i, j] + sumelements[i];
          

        }

    }
    return sumelements;

}

void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
    System.Console.WriteLine();
}
int FindMin(int[] array)            
{
    int min = array[0];
    int indexMin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            indexMin = i;
        }

    }
    return indexMin;
    
}
int rows = Prompt("Введите колличество строк = ");
int columns = Prompt("Введите колличество столбцов =");
int[,] array = CreateMatrix(rows, columns);
PrintMatrix(array, rows, columns);
System.Console.WriteLine();

int[] result = SumRows(array);
PrintArray(result);
System.Console.WriteLine($"Наименьшая сумма находится в строке {FindMin(result)+1}");
