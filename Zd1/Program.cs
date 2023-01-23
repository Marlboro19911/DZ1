/*Напишите программу, которая на вход принимает два числа и выдаёт,
 какое число большее, а какое меньшее.
Пример: a = 5; b = 7 ->  max = 7, min = 5
a = -9 b = -3 -> max = -3, min = -9 */
 
Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a>b)
{
    Console.WriteLine("a>b");
}
else if (b>a)
{
    Console.WriteLine("a<b");
}
else
{
    Console.WriteLine("a=b") ;
}