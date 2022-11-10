// Control-work #1
// Функция печатающая одномерный массив
void PrintArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

string [] array = {"hello", "2", "world", "^_^"};
PrintArray(array);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3){count ++;}
}

string [] resArray = new string [count];
int j = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        resArray[j] = array[i];
        j++;
    }
}

Console.WriteLine();
PrintArray(resArray);