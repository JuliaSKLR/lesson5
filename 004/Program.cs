//Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5


int[] CreateArray(int length)
{
    int[] answer = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(0, 1000);
    }
    return answer;
}
void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
    System.Console.WriteLine();
}

int findColArray(int[]a)
{
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] <= 99 && a[i] >= 10)
        {
            count++;
        }
    }
    return count;
}

int[] array = CreateArray(23);
PrintArray(array);
System.Console.WriteLine(findColArray(array));