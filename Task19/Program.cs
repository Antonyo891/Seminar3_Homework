// See https://aka.ms/new-console-template for more information
//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да
Console.Clear();
int Number = 0;
while (Number<10000||Number>99999){
System.Console.WriteLine("Введите пятизначное число");
Number = int.Parse(Console.ReadLine());
}
//       1         5        2             4
if  (Number/10000==Number%10&&(Number/1000)%10==(Number%100)/10)
System.Console.WriteLine($"Число {Number} - палиндром");
else System.Console.WriteLine($"Число {Number} - не является палиндромом");
//Console.WriteLine($"Div/10000 -> {Number/10000}");
//Console.WriteLine($"=Div%10 -> {Number%10}");
//Console.WriteLine($"(Div%100)/10 -> {(Number%100)/10}");
//Console.WriteLine($"(Div/1000)%10 -> {(Number/1000)%10}");
