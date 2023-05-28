// See https://aka.ms/new-console-template for more information
//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
Console.Clear();
int Number = 0;
while (Number<=1){
    Console.WriteLine("Введите число N больше 1");
    Number = int.Parse(Console.ReadLine());
}
for (int i = 1; i<=Number; i++)
    System.Console.Write($"Число {i} в 3 степени = {Math.Pow(i,3)}; ");
System.Console.WriteLine();