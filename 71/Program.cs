// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 

int Akkerman(int k, int l)
{
    if (k == 0) return l + 1;
    else
    {
        if ((k != 0) && (l == 0)) return Akkerman(k - 1, 1);
        else return Akkerman(k - 1, Akkerman(k, l - 1));
    }
}
Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Значение функции Аккермана = "+ Akkerman(m, n));
