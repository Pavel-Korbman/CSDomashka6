// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Решение для М вводимого пользователем:

Console.WriteLine("Сколько чисел вы хотите ввести?");
int lot = Convert.ToInt32 (Console.ReadLine());
int j=0;
for (int i = 0; i < lot; i++)
{
  Console.WriteLine("Введите число:");
int number = Convert.ToInt32 (Console.ReadLine());
if(number > 0) j++;  
}
Console.WriteLine("Положительных чисел: "+j);

// Решение для плавающего М:

// string next = "y";
// int i=0;
// while(next.ToLower() == "y")
// {
// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32 (Console.ReadLine());
// if(number > 0) i++;
// Console.WriteLine("Продолжить ввод? (Y - да, любой символ - нет)");
// next = Console.ReadLine();
// }

// Console.WriteLine(" Положительных чисел: "+i);
