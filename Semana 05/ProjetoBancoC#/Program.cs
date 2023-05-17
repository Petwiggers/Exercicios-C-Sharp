using ProjetoBancoC_.Models;
using ProjetoBancoC_.Serviços;


ExibirMenu();

void ExibirMenu()
{
  string opcao;
  do
  {
    System.Console.WriteLine("1 - Abrir uma nova Conta");
    System.Console.WriteLine("2 - Consultar Conta");
    System.Console.WriteLine("3 - Listar Contas");
    System.Console.WriteLine("4 - Sair");
    System.Console.WriteLine();
    System.Console.Write("Digite a opção desejada: ");
    opcao = Console.ReadLine();
    ServicoSelecionado(opcao);
  } while (opcao != "4");
}

void ServicoSelecionado(string opcao)
{
  ClienteService clienteService = new ClienteService();
  switch (opcao)
  {
    case "1":
      clienteService.CriarConta();
      break;
    case "2":
      System.Console.WriteLine("Digite o numero da conta desejada: ");
      int conta = int.Parse(Console.ReadLine());
      var cliente = clienteService.BuscarClientePorNumeroDeConta(conta);
      if (cliente == null)
      {
        System.Console.WriteLine("Conta não Cadastrada:");
      }
      else
      {
        System.Console.WriteLine(cliente.ResumoCliente());
      }
      break;
    case "3":
      clienteService.ExibirClientes();
      break;
    case "4":
      System.Console.WriteLine("Você saiu do Programa !");
      break;
    default:
      System.Console.WriteLine("Opção Inválida");
      break;
  }
}




