using desafio_bar;

Conta conta = new Conta();

Console.WriteLine("Sexo: ");
conta.Sexo = char.Parse(Console.ReadLine());

Console.WriteLine("Quantidade de cervejas: ");
conta.Cerveja = int.Parse(Console.ReadLine());

Console.WriteLine("Quantidade de refrigerantes: ");
conta.Refrigerante = int.Parse(Console.ReadLine());

Console.WriteLine("Quantidade de espetinhos: ");
conta.Espetinho = int.Parse(Console.ReadLine());

conta.Consumo(conta.Cerveja, conta.Espetinho, conta.Refrigerante);

conta.Couvert();

conta.Entrada(conta.Sexo);

conta.Total();

Console.WriteLine(conta);

