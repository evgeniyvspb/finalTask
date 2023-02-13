Console.WriteLine("Введите количество элементов в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
string[] matrix = new string[number];
for (int i = 0; (number - 1); i++)
{
    Console.WriteLine($"Введите {i + 1} значение массива: ");
    matrix[i] = Console.ReadLine();
}
// int correct =0;
// for (int i = 0; number-1; i++)
// {
//     if (matrix.Length[i]<4) correct++;
// }
// string[] matrixExit = new string[correct]; // матрица в которую мы запишем значение удовлетворяющие услвовию
// int countForMatrixExit = 0;
// for (int i = 0; number-1; i++)
// {
//     if (matrix.Length[i]<4) 
//     {
//         matrixExit[countForMatrixExit] = matrix.Length[i];
//         countForMatrixExit++;
//     }
// }

// PrintArray[matrix];
// Console.Write("->");
// PrintArray[matrixExit];

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i]);

    }
    Console.Write("]");
}