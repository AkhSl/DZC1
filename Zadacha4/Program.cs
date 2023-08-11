// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

 Console.WriteLine("Введите три целых числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int max1 = 0;

if (num1 > num2)
{
        max1 = num1; 
         System.Console.WriteLine($"{num1}, {num2}, {num3} -> {max1}");
}
else if (num2 > num3)
{
     max1 = num2;
     System.Console.WriteLine($"{num1}, {num2}, {num3} -> {max1}");
}
 else
      System.Console.WriteLine($"{num1}, {num2}, {num3} -> {num3}");

