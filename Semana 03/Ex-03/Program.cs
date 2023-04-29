using Ex_03;

Cliente cliente = new Cliente("Peterson", "02331278801");
ContaBancaria contaBancaria = new ContaBancaria(102, cliente);

contaBancaria.ExibirDados();
System.Console.WriteLine("\n");
contaBancaria.Depositar(500);
System.Console.WriteLine("\n");
contaBancaria.Sacar(200);
System.Console.WriteLine("\n");
System.Console.WriteLine(contaBancaria.ToString());

