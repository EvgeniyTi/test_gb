Console.Clear();

void Main()
{
    string[] userArray = InputItems();
    string[] finalArray = FinalArray(userArray);
    Console.Write($"[{String.Join(", ", userArray)}] -> [{String.Join(", ", finalArray)}]");
}

string[] InputItems()
{
    Console.Write("Введите массив строк через пробел: ");
    return Console.ReadLine().Split(" ");
}

string[] FinalArray(string[] array)
{
    string[] newArray = new string[CountItems(array)];

    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;

        }
    }

    return newArray;
}

int CountItems(string[] userArray)
{
    int count = 0;
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i].Length <= 3)
        {
            count++;
        }
    }

    return count;
}

Main();
