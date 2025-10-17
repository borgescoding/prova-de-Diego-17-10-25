using System;

Console.Write("Digite o número inicial: ");
int start = int.Parse(Console.ReadLine());

Console.Write("Digite o número final: ");
int end = int.Parse(Console.ReadLine());

for (int i = start; i <= end; i++)
{
    Console.WriteLine($"\nTabuada do {i}:");
for (int j = 1; j <= 10; j++)
{
Console.WriteLine($"{i} x {j} = {i * j}");
}
}
