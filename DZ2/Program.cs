// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int sumOfDigits (int number)
{
    int result = 0;
    while (number>0)
    {
        result = result + number % 10;
        number = number / 10;
    }
    return result;
}

Console.Write("Ввелите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

Console.Write($"Сумма цифр числа {Number} равна {sumOfDigits(Number)}");