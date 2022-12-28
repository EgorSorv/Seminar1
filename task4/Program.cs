int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int number = Prompt("Введите число: ");

if (number >= 0) Console.WriteLine($"Модуль числа {number}  равен {number}");
else Console.WriteLine($"Модуль числа {number} равен {-number}");
