int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int value1 = Prompt("Введите первое число: ");
int value2 = Prompt("Введите второе число: ");

if (value1 == value2 * value2)
{
    Console.WriteLine($"Число {value1} является квадратом {value2}");
}
else if (value2 == value1 * value1)
{
    Console.WriteLine("Число " + value2 + " является квадратом числа " + value1);

}
else Console.WriteLine("Ни одно из чисел не является квадратом другого");
