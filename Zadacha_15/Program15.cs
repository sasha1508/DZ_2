// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.Write("Введи номер дня недели: ");
int Chislo = Convert.ToInt32(Console.ReadLine());
if (Chislo < 1 || Chislo > 7) 
{
    Console.Write("Введено неправильное число");
}
else
{
    if (Chislo < 6)
    {
        Console.WriteLine("Рабочий день");
    }
    else
    {
        Console.WriteLine("Выходной");
    }
   
}