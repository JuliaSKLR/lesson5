// Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21


int[] CreateArray(int length)
{
    int[] answer = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(0, 5);
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

int[] MultiPairArray(int[] a)
{
    int count = a.Length;
    int[] pairs = new int [(count / 2) + (count % 2)];
    pairs[pairs.Length-1] = a[pairs.Length-1];
    for (int i = 0; i < count /2; i++)
    {
        pairs[i] = a[i] * a[a.Length-i-1];
    }
    return pairs;
}

int[] array = CreateArray(7);
PrintArray(array);
PrintArray(MultiPairArray(array));
