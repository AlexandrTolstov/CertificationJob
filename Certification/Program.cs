Console.WriteLine("Введите количество строк в массиве:");
Console.Write("NumOfString = ");
int NumOfString = Convert.ToInt32(Console.ReadLine());
string[] Strings = new string[NumOfString];

Console.WriteLine("Введите строки массива:");
for (int i = 0; i < Strings.Length; i++)
{
    Console.Write($"Str{i+1} = ");
    Strings[i] = Console.ReadLine();
}
