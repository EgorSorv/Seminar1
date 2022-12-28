double Prompt(string message)
{
    Console.Write(message);
    double value = double.Parse(Console.ReadLine() ?? "0");
    return value;
}

double value = Prompt("Введите число: ");
Console.WriteLine("Обратным значением числа " + value + " будет число " + (1 / value));
