using System;

int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}




int a = ReadInt("введите число");
Console.Write("введите знак");
string b = Console.ReadLine();
int c = ReadInt("введите число");
double g = 0;
if(b == "+")
{
    g = a + c;
    Console.WriteLine($"{a} + {c} = {g}");
}

if (b == "-")
{
    g = a - c;
    Console.WriteLine($"{a} - {c} = {g}");
}
if (b == "*")
{
    g = a * c;
    Console.WriteLine($"{a} * {c} = {g}");
}
if (b == "/")
{
    g = a / c;
    Console.WriteLine($"{a} / {c} = {g}");
}