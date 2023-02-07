// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int NumberRequest (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int WorkHoliday (int number)
{
 if (number > 0 && number < 8)
    {
        if (number == 7 || number == 6)
        {
            Console.Write("Под цифрой " + number + " - Выходной");
        }
        else
        {
            Console.Write("Под цифрой " + number + " - Рабочий");
        }
    }
 else
    {
        Console.Write("Вы ввели число не в пределах от 1 до 7, не возможно определить");
    }
}