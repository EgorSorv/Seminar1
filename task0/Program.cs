int Prompt(string message)
{
    Console.Write(message);
    string inputString = Console.ReadLine();
    int value = Convert.ToInt32(inputString);
    return value;
}

int value = Prompt("Введите число: ");
int square = value * value;
Console.WriteLine($"Квадрат числа {value} равен {square}");
