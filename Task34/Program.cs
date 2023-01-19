// Задача 34: Задайте массив заполненный случайными 
//положительными трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2



void input_array (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

int evenNumbers (int[] array)
{
    int Even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
            Even = Even + 1;
    }
    return Even;
}

Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
input_array (array);
Console.WriteLine($"[{string.Join(", ", array)}]");

Console.WriteLine(evenNumbers(array));