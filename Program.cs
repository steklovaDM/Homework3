bool task19(string? input)
{
    if (String.IsNullOrEmpty(input) || input.Length != 5)
    {
        Console.WriteLine("Неверное число");
        return false;
    }

    for (int i = 0; i < input.Length / 2; i++)
    {
        if (input[i] != input[input.Length - 1 - i])
            return false;
    }
    return true;
}

void task23(ushort n)
{
    for (ushort i = 1; i <= n; i++)
    {
        Console.WriteLine(i * i * i);
    }
}

Console.WriteLine("Введите пятизначное число\n");
string? input = Console.ReadLine();

bool polindrom = task19(input);
Console.WriteLine(polindrom);


Console.WriteLine("Введите число\n");
ushort n = Convert.ToUInt16(Console.ReadLine());
task23(n);
