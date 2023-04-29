using Ex_04;

ContaBancaria conta = new ContaBancaria();
conta.Depositar(500);
bool deuCerto = conta.Sacar(200);
System.Console.WriteLine(deuCerto);
