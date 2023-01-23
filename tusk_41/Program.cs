//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

int getUserLenght(string massege)
{
    Console.WriteLine(massege);
    int lenghtArray = int.Parse(Console.ReadLine()!);
    return lenghtArray;
}

int Counter(int len)
{
    int number = 0;
    int count = 0;
    int count1 = 0;
    while(count < len)
    {
        Console.Write("Введите число: ");
        number = int.Parse(Console.ReadLine()!);
        if (number > 0)
        {
            count1++;
        }
        count++;
    }
    return count1;
}

int Number = getUserLenght("Введите количество чисел: ");
int result = Counter(Number);
Console.WriteLine($"{result} чисел больше 0.");