// 69: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму элементов в промежутке от M до N.
int Sum(int k, int l)
{
    int summa = l;
    if(l==k) return summa;
    return summa+Sum(k,l-1);
}
Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
Console.Write($"Сумма чисел от {m} до {n} = ");
Console.WriteLine(Sum(m,n));