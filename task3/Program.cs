int Prompt(string message)
{
    Console.Write(message);
    int value = int.Parse(Console.ReadLine() ?? "0");
    return value;
}

int value = Prompt("Введите число: ");
int counter = -value;

while (counter <= value)
{
    Console.Write(counter + " ");
    counter++;
}
