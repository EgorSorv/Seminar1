int Prompt(string message)
{
    Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int dayOfTheWeekNumber = Prompt("Введите номер дня недели: ");
string [] days = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};

if (dayOfTheWeekNumber < 1 || dayOfTheWeekNumber > 7) Console.WriteLine("Такого дня недели не существует");
else Console.WriteLine($"{days[dayOfTheWeekNumber - 1]} - {dayOfTheWeekNumber} день недели");
