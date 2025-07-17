using desafio_bar;

Conta conta = new Conta();

Console.WriteLine("Sexo: ");
conta.Gender = char.Parse(Console.ReadLine());

Console.WriteLine("Quantidade de cervejas: ");
conta.Beer = int.Parse(Console.ReadLine());

Console.WriteLine("Quantidade de refrigerantes: ");
conta.SoftDrink = int.Parse(Console.ReadLine());

Console.WriteLine("Quantidade de espetinhos: ");
conta.Barbecue = int.Parse(Console.ReadLine());

conta.Feeding(conta.Beer, conta.Barbecue, conta.SoftDrink);

conta.Cover();

conta.Ticket(conta.Gender);

conta.Total();

Console.WriteLine(conta);

