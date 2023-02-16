// Задача 13: Напишите программу, которая выводит третью цифру заданного семизначного числа или сообщает, что третьей цифры нет.

// 78 -> третьей цифры нет

// 3267900 -> 6

// ДОП: цифра третья может быть как с левой стороны, так и с правой

Console.Clear();
Console.Write("Введи семизначное число: ");
int Chislo = Convert.ToInt32(Console.ReadLine());
if (Chislo < 1000000 || Chislo > 9999999) 
{
    if (Chislo < 100)
    {
        Console.Write("Третьей цифры нет. Введено не семизначное число");
    }
    else
    {
        Console.Write("Введено не семизначное число");
    }
}
else
{
    int VtorayaCifraSleva = (Chislo / 10000) % 10;
    int VtorayaCifraSprava = (Chislo / 100) % 10;
    Console.WriteLine($"Третья цифра слева: {VtorayaCifraSleva}");
    Console.WriteLine($"Третья цифра справа: {VtorayaCifraSprava}");
}