using System;

Console.WriteLine("Calcular media ponderada.");
double n1, p1;
double n2, p2;
double n3, p3;
Console.Write("1.Nota: "); n1 = Convert.ToDouble(Console.ReadLine());
Console.Write("1.Peso: "); p1 = Convert.ToDouble(Console.ReadLine());

Console.Write("2.Nota: "); n2 = Convert.ToDouble(Console.ReadLine());
Console.Write("2.Peso: "); p2 = Convert.ToDouble(Console.ReadLine());

Console.Write("3.Nota: "); n3 = Convert.ToDouble(Console.ReadLine());
Console.Write("3.Peso: "); p3 = Convert.ToDouble(Console.ReadLine());

double media = ((n1 * p1) + (n2 * p2) + (n3 * p3)) / (p1 + p2 + p3);
Console.WriteLine($"Media: {media}");

if (media >= 7.0)
{
    Console.WriteLine("Aprovado");
}
else if (media >= 5.0)
{
    Console.WriteLine("Recuperação final");
}
else
{
    Console.WriteLine("Recuperação final");
}