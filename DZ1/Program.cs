// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int exponent (int number, int degree)
{
    int result = 1;    
    for (int i=1; i<=degree; i++)
    {
        result = result * number;
    }

    return result;
}


Console.Write("Ввелите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввелите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write($"Число {A} в степени {B} равно {exponent(A, B)}");
