// Напишите программу, которая на вход принимает число и выдает, является
//ли число четным(делится ли на 2 без остатка).

Console.Clear();
Console.Write("Введите 1 число:");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 2 == 0)
   Console.WriteLine($"четное");
else
   Console.WriteLine($"нечетное");
   