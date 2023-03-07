// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

int[] InputArray (int length)
{
    int[] array = new int[length];
    Random randon = new Random();
    for (int i = 0; i<length; i++)
    {
        array[i] = randon.Next(1, 10);
    }
    return array;

}

void PrintArray (int[] array)
{
    for (int i = 0; i<=array.Length-1; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.WriteLine("Полученный массив");
int[] array = InputArray(8);
PrintArray(array);