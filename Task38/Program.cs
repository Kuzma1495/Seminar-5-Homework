// Задача 38: Задайте массив чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


void input_array(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 50); 
}
int numberMax(int[] array)
{
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

int numberMin(int[] array)
{
   
    int min = int.MaxValue;;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
input_array(array);
Console.WriteLine($"[{string.Join(", ", array)}]");

int a = numberMax(array);
Console.WriteLine("Максимальное число: " + a);

int b = numberMin(array);
Console.WriteLine("Минимальное число: " + b);

int c = a - b;
Console.WriteLine("Разница: " + c);