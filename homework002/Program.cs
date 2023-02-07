// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int GetNumber ()
{
    Random rnd = new Random ();
    int result = rnd.Next(100,1000);
    return result;
}


int GetThirdOfNumber (int number)
{
if (number <100)
{
    Console.WriteLine ("третьей цифры нет");
}
else
{
    int firstDigit = number / 100;
    int secondDigit = number % 10;
    return number % 10;
}
}
int number = GetNumber ();
int result = GetThirdOfNumber (number);

Console.WriteLine($"Было:{number}, Стало: {result}");