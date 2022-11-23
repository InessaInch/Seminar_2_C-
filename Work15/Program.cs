/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.Write ("Введите номер дня недели (числа от 1 до 7): ");
int DayOfWeek = Convert.ToInt32(Console.ReadLine());
if(DayOfWeek ==6||DayOfWeek ==7)
{
    Console.WriteLine("Это выходной день");
}
else if(DayOfWeek<1||DayOfWeek>7)
{
    Console.WriteLine("Ой...не существует такого дня, попробуй еще раз");
}
else
{
    Console.WriteLine("Это будний день");
}