/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

Console.Write ("Введите любое число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int ThirdDigit(int Number)
        {
            int result = -1;
            if (Number >= 100)
            {
                while (Number > 999)
                {
                    Number = Number / 10;
                }
                result = Number % 10;
            }
            return result; 
        }
if(ThirdDigit(Number)==-1)
Console.WriteLine("Третьей цифры нет");
else
Console.WriteLine($"третье число {ThirdDigit(Number)}");
Console.WriteLine();