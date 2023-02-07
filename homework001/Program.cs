// Напишите программу, котроая принимает на вход трехзначное число, а на выходе показывает вторую цифру этого числа.
// 536->"3"
// 248->"4"
// 654->"5"

int GetNumber ()
{
    Random rnd = new Random ();
    int result = rnd.Next(100,1000);
    return result;
}

int GetSecondOfNumber (int number)
{
    int firstDigit = number / 100;
    int secondDigit = number % 10;
    return number / 10 % 10;
}

int number = GetNumber ();
int result = GetSecondOfNumber (number);

Console.WriteLine($"Было:{number}, Стало: {result}");
