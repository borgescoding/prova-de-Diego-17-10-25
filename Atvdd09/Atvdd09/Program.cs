{ 
    string[] nomes = { "Micael", "Diego", "Pedro", "Isabelly", "Lucas" };

    Console.Write("Digite um nome para pesquisar: ");
    string nomeBusca = Console.ReadLine();

    foreach (string nome in nomes)
    {
        if (nome.Equals(nomeBusca)) 
        {
            Console.WriteLine($"O nome {nomeBusca} foi encontrado no vetor.");
            return; 
        }
        else
        {
            Console.WriteLine("O nome não foi encontrado");
        }
    }
}