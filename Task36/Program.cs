// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0



void input_array (int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
}

int oddNumbers (int[] array)
{
    int summOdd = 0;
    for(int i = 1; i < array.Length; i++)
    {
        if (i%2!=0)
        {
            summOdd = summOdd + array[i];
        }
    }
    return summOdd;
}

Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
input_array (array);
Console.WriteLine($"[{string.Join(", ", array)}]");

Console.WriteLine(oddNumbers(array));