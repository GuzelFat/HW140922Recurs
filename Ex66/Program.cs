// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int GetNumber(string what)
{
    int number;
    Console.Write($"Введите число {what}: ");
    while ( !int.TryParse( Console.ReadLine(), out number))
    {
        Console.Write( " Введите корректное число:");
    }
return number;
}

int GetSumRec(int m, int n)
{
    if (m >= n) return 0;
    // int s=(m+n)*(n-m+1)/2;
    // return s;
    return (m+n)*(n-m+1)/2 + GetSumRec( m+n,n-m+1);
    // return m + n + GetSumRec( m+1 , n-1 );
}

int GetSum( int m, int n)
{
    int sum = 0;
    for (int i = m; i <= n ; i++)
    {
        sum += i;
    }
    return sum;
}
Console.WriteLine("");
int m = GetNumber("m");
int n = GetNumber("n");

Console.WriteLine("");
Console.WriteLine($"Сумма натуральных чисел между ними равна: { GetSum(m,n)}");
Console.WriteLine($"А если посчитать через рекурсию, то:{GetSumRec(m,n)}");
Console.WriteLine("");