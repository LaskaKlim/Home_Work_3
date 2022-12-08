Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();

int Length = number.Length;

if (Length == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - не палиндром");
    }
}
else
{
    Console.WriteLine($" error: {number} - число некорректное");
}