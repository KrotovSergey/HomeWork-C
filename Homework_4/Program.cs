﻿Console.Clear();

Console.WriteLine("Какую задачу проверить?: 25/27/29 ");

int zadacha = int.Parse(Console.ReadLine());

if (zadacha == 25)
{
    Zadacha1();
}
else if (zadacha == 27)
{
    Zadacha2();
}
else if (zadacha == 29)
{
    Zadacha3();
}


void Zadacha1()
{
    Console.WriteLine("Введите число: ");

    int a = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите число: ");

    int b = int.Parse(Console.ReadLine());

    Console.WriteLine($"число {a} в степени {b} = {Math.Pow(a, b)}");

}

void Zadacha2()
{
    Console.Write("Введите число: ");
    int a = int.Parse(Console.ReadLine());

    int SumNumber(int a)
    {
        int counter = Convert.ToString(a).Length;
        int advance = 0;
        int result = 0;
        for (int i = 0; i < counter; i++)
        {
            advance = a - a % 10;
            result = result + (a - advance);
            a = a / 10;
        }
        return result;
    }
    int sumNumber = SumNumber(a);
    Console.WriteLine("Сумма цифр в заданном числе: " + sumNumber);

}

void Zadacha3()
{
    Console.Write("Из скольки чисел вы хотите увидеть массив?: ");

    int a = int.Parse(Console.ReadLine());

    int[] arr = new int[a];

    Random rand = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 100);
    }
    Console.WriteLine(string.Join(", ", arr));

}