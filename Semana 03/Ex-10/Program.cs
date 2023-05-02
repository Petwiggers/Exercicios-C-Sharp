using Ex_10;

ContaBancaria conta = new ContaBancaria();
conta.Depositar(5000);
bool saque = conta.Sacar(2000);
System.Console.WriteLine("O saque " + (saque ? "foi realizado com sucesso" : "não foi realizado com sucesso"));
conta.MostrarSaldo();
conta.Depositar(1000);
conta.Extrato();
