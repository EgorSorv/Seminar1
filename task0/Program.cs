int Prompt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine() ?? "0");
    return value;
}

int value = Prompt("Введите число: ");
int square = value * value;
Console.WriteLine($"Квадрат числа {value} равен {square}");
