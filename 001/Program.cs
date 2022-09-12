// Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.

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

void PrintArray(int[,] array, int rows, int columns)
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

int[,] RegularizeArray(int[,] array)
{
   
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {          
            for (int k = 0; k < array.GetLength(1) - 1 - j; k++)
            {

                if (array[i, k] > array[i, k + 1])         
                {
                    temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
           
        }

    }
    return array;
}

int rows = Prompt("Введите колличество строк = ");
int columns = Prompt("Введите колличество столбцов =");
int[,] array = CreateMatrix(rows, columns);
PrintArray(array, rows, columns);
System.Console.WriteLine();

int[,] result = RegularizeArray(array);
PrintArray(result, rows, columns);
