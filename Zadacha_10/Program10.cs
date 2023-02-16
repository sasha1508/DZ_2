// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.Write("Введи трёхзначное число: ");
int Chislo = Convert.ToInt32(Console.ReadLine());
if (Chislo < 100 || Chislo > 999) 
{
    Console.Write("Введено не трёхзначное число");
}
else
{
    int VtorayaCifra = (Chislo / 10) % 10;
    Console.WriteLine($"Вторая цифра: {VtorayaCifra}");
}
