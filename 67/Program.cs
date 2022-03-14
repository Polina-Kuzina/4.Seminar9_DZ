// 67. Показать натуральные числа от N до 1, N задано
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());

string Print(int k)
{
    if(k<1) return string.Empty;
    return k.ToString()+ " "+Print(k-1);
}
Console.WriteLine(Print(n));