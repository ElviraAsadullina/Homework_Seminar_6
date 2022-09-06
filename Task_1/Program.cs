New:
Console.WriteLine("Введите любое натуральное число: ");
int M = Convert.ToInt32(Console.ReadLine());
int count = 0;
if(M <= 0)
{
    Console.WriteLine("Введенное число не натуральное!");
    goto New;
}
Console.WriteLine($"Введите любые {M} чисел через Enter: ");
for(int i = 0; i < M; i++)
{
    string s = Console.ReadLine();
    double m = Convert.ToDouble(s);
    if(m > 0)
    {
        count += 1;
    }
}
Console.WriteLine($"Количество введенных положительных чисел = {count}"); 