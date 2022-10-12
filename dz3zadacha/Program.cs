/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("");
int num1 = 1;
int result = 0;
while (num1 <= n )
{
    
    
    result = (int)Math.Pow(num1 ,3);
    Console.WriteLine(result);
    num1++;
}
