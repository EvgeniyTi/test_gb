Console.Clear();

void Main(string args)
{
    string[] numbers = args.Split(',');

    //int count = 0;
    //for (int i = 0; i < numbers.Length; i++)
    //{
    //    if (Convert.ToInt64(numbers[i]) > 0) count++;
    //}
    //Console.WriteLine(String.Join(",", numbers));
    //Console.Write($"{String.Join(" ", numbers).Trim()}");
}

Console.Write("Ввведите с клавиатуры массив строк: ");
Main(args: Console.ReadLine());