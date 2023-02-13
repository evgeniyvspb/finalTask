Console.WriteLine("Введите количество элементов в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
string[] matrix = new string[number];
for (int i = 0; i < number; i++)
{
    Console.WriteLine($"Введите {i + 1} значение массива: ");
    matrix[i] = Console.ReadLine();
}
int correct = 0; // создаём массив с нужным количеством элементов
for (int i = 0; i < number; i++)
{
    if (Size(matrix[i]) < 4) correct++;
}
string[] matrixExit = new string[correct]; // матрица в которую мы запишем значение удовлетворяющие услвовию
int countForMatrixExit = 0;
for (int i = 0; i<number; i++)
{
    if (Size(matrix[i]) < 4)
    {
        matrixExit[countForMatrixExit] = matrix[i];
        countForMatrixExit++;
    }
}

PrintArray(matrix);
Console.Write("->");
PrintArray(matrixExit);

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

int Size(string number)
{
    int size =0;
    size = number.Length;
    return size;
}