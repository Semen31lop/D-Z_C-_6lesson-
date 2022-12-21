//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
int[] GetArray(int size, int minValue, int maxValue)
{
int[] res= new int[size];
for (int i = 0; i < size; i++)
{
    res[i]= new Random().Next(minValue,maxValue);
}
return res;
}
void PrintArray(int[] arr )
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
int[]array= GetArray(5,-10,10);
PrintArray(array);
int count=0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]>0)
    {
        count++;
    }
}
Console.WriteLine($"-->{count}");