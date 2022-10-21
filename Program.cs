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


Console.WriteLine($"{numbers.Length} чиселв массиве, чётных из них {count}");

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
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine("]");
}