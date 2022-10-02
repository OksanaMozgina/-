Console.WriteLine("Введите первое число: ");
int num_A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num_B = int.Parse(Console.ReadLine());

if (num_A > num_B)
{
    Console.WriteLine($"{num_A} больше чем {num_B}");
}
else
{
    Console.WriteLine($"{num_B} больше чем {num_A}");
}