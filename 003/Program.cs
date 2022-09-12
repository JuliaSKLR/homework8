// Задайте две матрицы. Напишите программу, которая будет 
//находить произведение двух матриц.
//Матрицу C, элементы cij которой вычисляются по следующей формуле: cij=ai0×b0j+ai1×b1j+...+aip×bpj, i=1,...m, j=1,...m


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
            answer[i, j] = rnd.Next(0, 5);
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


int[,] multiplication(int[,] arrayA, int[,] arrayB)
{
    int[,] result = new int[arrayA.GetLength(0), arrayB.GetLength(1)];  
    int sum = 0;

    for (int i = 0; i < arrayA.GetLength(0); i++)
    {

        for (int j = 0; j < arrayB.GetLength(1); j++)
        {
            for (int k = 0; k < arrayA.GetLength(1); k++)
            {
                sum = arrayA[i,k] * arrayB[k,j] + sum;
            }
            result[i , j] = sum;
            sum = 0;
        }

    }
    return result;

}



int rowsa = Prompt("Введите колличество строк в первой матрице  = ");
int columnsa = Prompt("Введите колличество столбцов в первой матрице =");
int[,] arrayA = CreateMatrix(rowsa, columnsa);
int rowsb = Prompt("Введите колличество строк во второй матрице = ");
int columnsb = Prompt("Введите колличество столбцов во второй матрице =");
int[,] arrayB = CreateMatrix(rowsb, columnsb);
PrintArray(arrayA, rowsa, columnsa);
System.Console.WriteLine();
PrintArray(arrayB, rowsb, columnsb);
System.Console.WriteLine();
    
if (rowsa != columnsb && columnsa != rowsb)
{
    System.Console.WriteLine("Матрицы не могут быть перемножены");
    return;
}
    

int[,] result = multiplication(arrayA, arrayB);
PrintArray(result, rowsa, columnsb);

