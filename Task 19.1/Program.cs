// See https://aka.ms/new-console-template for more information
/*Задача 
Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
Console.Clear();
int Number = 0, Length =0, i = 1;
string Str = "", result = "палиндром";
while (Number<10&&Number>-10){
System.Console.WriteLine("Введите число(не меньше двухзначного)");
Str = Console.ReadLine();
Length = Str.Length;
Number = int.Parse(Str);
}
while (i<=Length/2)
 { if (Number%Convert.ToInt32(Math.Pow(10,i))/Convert.ToInt32(Math.Pow(10,i-1))==Number/Convert.ToInt32(Math.Pow(10,Length-i))%10)
 
   
    //System.Console.WriteLine($"Цифра {Length+1-i} -> {Number%Convert.ToInt32(Math.Pow(10,i))/Convert.ToInt32(Math.Pow(10,i-1))}");
    //System.Console.WriteLine($" Цифра {i} -> {(Number/Convert.ToInt32(Math.Pow(10,Length-i))%10)}");
    //System.Console.WriteLine($"Convert.ToInt32(Math.Pow(10,Length-i)) -> {Convert.ToInt32(Math.Pow(10,Length-i))}");
    //System.Console.WriteLine($"Convert.ToInt32(Math.Pow(10,i-1)) -> {Convert.ToInt32(Math.Pow(10,i-1))}");
    i++;
 else 
{
i=Length;
result = "не является палиндромом";
 }}
System.Console.WriteLine($"Число {Number} {result} ");
//System.Console.WriteLine($"Число {Number} - палиндром");
//else System.Console.WriteLine($"Число {Number} - не является палиндромом");
//Console.WriteLine($"Div/10000 -> {Number/10000}");
//Console.WriteLine($"=Div%10 -> {Number%10}");
//Console.WriteLine($"(Div%100)/10 -> {(Number%100)/10}");
//Console.WriteLine($"{Str}");
//Console.WriteLine($"{Number}");
//Console.WriteLine($"{Length}");
