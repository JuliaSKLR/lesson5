//Напишите программу замены элементов массива: положительные элементы
// замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] CreateArray(int length, int min, int max)
{
    int[] answer = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(min, max + 1);
    }
    return answer;
}

void PrintArray(int[] array) // вывод массива на консоль
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
    System.Console.WriteLine();
}

int[] Perevorot(int[] a)
{
    int count = a.Length;
    for (int i = 0; i < count; i++)
    {
        a[i] = -a[i];
    }
    return a;
}
int[] array1 = CreateArray(8, -40, 40);
PrintArray(array1);
PrintArray(Perevorot(array1));