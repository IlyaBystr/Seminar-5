/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
/*
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
randomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArr(numbers);
int count = 0;

for (int i = 0; i < numbers.Length; i++)
    if (numbers[i] % 2 == 0)
    {
        count++;
    }


Console.WriteLine($"чётных чисел в массиве {count}");

void randomNumbers(int[] numbers)
{
    for (int a = 0; a < numbers.Length; a++)
    {
        numbers[a] = new Random().Next(100, 1000);
    }
}
void PrintArr(int[] numbers)
{
    Console.Write("[ ");
    for (int b = 0; b < numbers.Length; b++)
    {
        Console.Write(numbers[b] + " ");
    }
    Console.WriteLine("]");
}
*/

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

/*
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
randomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArr(numbers);
int sum = 0;

for (int i = 0; i < numbers.Length; i += 2)
    sum = sum + numbers[i];

Console.WriteLine($"сумма элементов на нечётных позициях = {sum}");

void randomNumbers(int[] numbers)
{
    for (int a = 0; a < numbers.Length; a++)
    {
        numbers[a] = new Random().Next(1, 100);
    }
}
void PrintArr(int[] numbers)
{
    Console.Write("[ ");
    for (int b = 0; b < numbers.Length; b++)
    {
        Console.Write(numbers[b] + " ");
    }
    Console.WriteLine("]");
}
*/

/*
Задача 38: Задайте массив вещественных чисел(просто от минус бесконечности, до плюс бесконечности, с дробными не работаем). Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

/*
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
randomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArr(numbers);
int min = Int32.MaxValue;
int max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        {
            max = numbers[i];
        }
    if (numbers[i] < min)
        {
            min = numbers[i];
        }
}

Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void randomNumbers(int[] numbers)
{
    for(int a = 0; a < numbers.Length; a++)
        {
            numbers[a] = Convert.ToInt32(new Random().Next(-100000,100000));
        }
}
void PrintArr(int[] numbers)
{
    Console.Write("[ ");
    for(int b = 0; b < numbers.Length; b++)
        {
            Console.Write(numbers[b] + " ");
        }
    Console.WriteLine("]");
}
*/