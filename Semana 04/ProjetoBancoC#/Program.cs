using ProjetoBancoC_.Models;
using ProjetoBancoC_.Serviços;


ClienteService clienteService = new ClienteService();
clienteService.ComandoInicial();
clienteService.CriarConta();
clienteService.ExibirClientes();
Cliente cliente = clienteService.BuscarClientePorNumeroDeConta(1);
System.Console.WriteLine("Cliente da conta 1" + cliente.ResumoCliente());




