// See https://aka.ms/new-console-template for more information
/*Доп. задача
На столе лежат n монеток. Некоторые из них лежат вверх решкой,
а некоторые – гербом. Определите минимальное число монеток, которые нужно перевернуть,
чтобы все монетки были повернуты вверх одной и той же стороной.
1-Решка (tails)
0-Герб(head)*/
Console.Clear();
int Number= 0, tails = 0, head = 0;
while (Number<=2) {
    System.Console.WriteLine("Сколько монеток на столе");
    Number = int.Parse(Console.ReadLine());
    if (Number<=2) System.Console.WriteLine("на столе не должно быть меньше 3-х монет");}
int [] array = new int [Number];
for (int i = 0; i<Number; i++)
{
    //Console.WriteLine($"Как лежит {i+1} монетка (1 - решкой вверх, 0 - гербом вверх)");
    //array[i] = int.Parse(Console.ReadLine());
    array[i] = new Random().Next(0,2);
    System.Console.Write($" {array[i]} ");
    if (array[i] == 1) 
    tails++; else
    head++;
}
System.Console.WriteLine();
if (head>tails) 
System.Console.WriteLine($"Чтобы все монеты лежали вверх гербом нужно перевернуть {Number-head} монет которые лежат вверх решкой");
else
System.Console.WriteLine($"Чтобы все монеты лежали вверх решкой нужно перевернуть {Number-tails} монет которые лежат вверх решкой");
