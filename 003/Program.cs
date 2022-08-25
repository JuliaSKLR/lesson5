// Задайте массив. Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да

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
bool FindElement(int[] a, int num)
{
    int count = a.Length;
    int i = 0;
    while (i < count)
    {
        if (a[i] == num) return true;
            i++;

    }
    return false;

}
int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

int[] array = CreateArray(10, 0, 50);
PrintArray(array);
int num = Prompt("Enter number for search ");
if (FindElement(array, num))
{
    System.Console.WriteLine($"Элемент{num} присутствует в массиве");
}
else
{
    System.Console.WriteLine($"Элемент {num} отсутствует в массиве");
}