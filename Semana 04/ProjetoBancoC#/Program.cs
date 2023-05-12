using ProjetoBancoC_.Models;
using ProjetoBancoC_.Serviços;

// Cliente pessoaFisica = new PessoaFisica(0, "Rua Major", "0123", "Peterson", new DateTime(2004, 06, 15));
// Cliente pessoaFisica2 = new PessoaFisica(1, "Rua Maria", "4321", "Henrique", new DateTime(2002, 06, 04));
// pessoaFisica.ResumoCliente();
// pessoaFisica2.ResumoCliente();

// ClienteService clienteService = new ClienteService();
// clienteService.ComandoInicial();
// clienteService.CriarConta();
// clienteService.ExibirClientes();
// Cliente cliente = clienteService.BuscarClientePorNumeroDeConta(1);
// System.Console.WriteLine("Cliente da conta 1" + cliente.ResumoCliente());

Cliente pessoaJuridica = new PessoaJuridica(2, "Rua Airton", "012456", "Albras");
System.Console.WriteLine(pessoaJuridica.ResumoCliente());


