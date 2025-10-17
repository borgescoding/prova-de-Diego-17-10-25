using System;

int candidatoA = 0, candidatoB = 0, candidatoC = 0, nulo = 0;
int voto = -1;

do
{
    Console.WriteLine("Sistema de Votação");
    Console.WriteLine("1 - Candidato A");
    Console.WriteLine("2 - Candidato B");
    Console.WriteLine("3 - Candidato C");
    Console.WriteLine("9 - Voto Nulo");
    Console.WriteLine("0 - Encerrar votação e ver resultado");
    Console.Write("Digite sua opção: ");

    if (int.TryParse(Console.ReadLine(), out voto))
    {
        switch (voto)
        {
            case 1:
                candidatoA++;
                break;
            case 2:
                candidatoB++;
                break;
            case 3:
                candidatoC++;
                break;
            case 9:
                nulo++;
                break;
            case 0:
                Console.WriteLine("\nProcessando resultados...");
                break;
            default:
                Console.WriteLine(">>> Opção inválida. Digite 1, 2, 3, 9 ou 0.");
                break;
        }
    }
    else
    {
        Console.WriteLine(">>> Entrada inválida. Por favor, digite apenas números.");
        voto = -1;
    }

} while (voto != 0);

Console.WriteLine("Resultado Final");
Console.WriteLine($"Candidato A: {candidatoA} votos");
Console.WriteLine($"Candidato B: {candidatoB} votos");
Console.WriteLine($"Candidato C: {candidatoC} votos");
Console.WriteLine($"Votos nulos: {nulo}");