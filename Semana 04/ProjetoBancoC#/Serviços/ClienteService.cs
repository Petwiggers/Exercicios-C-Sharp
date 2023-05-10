using ProjetoBancoC_.Models;

namespace ProjetoBancoC_.Serviços
{
  public class ClienteService
  {
    private static List<Cliente> _listaClientes = new List<Cliente>();

    public void ComandoInicial()
    {
      Cliente pessoaFisica = new PessoaFisica(0, "Rua Major", "0123", "Peterson", new DateTime(2004, 06, 15));
      Cliente pessoaFisica2 = new PessoaFisica(1, "Rua Maria", "4321", "Henrique", new DateTime(2002, 06, 04));
      _listaClientes.Add(pessoaFisica);
      _listaClientes.Add(pessoaFisica2);
    }

    public void CriarConta()
    {
      System.Console.WriteLine("Qual o tipo da sua conta ?");
      System.Console.WriteLine();
      System.Console.WriteLine("1 - Conta Pessoa Física");
      System.Console.WriteLine("2 - Conta Pessoa Jurídica");
      string tipoConta = Console.ReadLine();

      if (tipoConta == "1")
      {
        System.Console.WriteLine("CriarContaPessoaFisica");
        // CriarContaPessoaFisica()
      }
      else if (tipoConta == "2")
      {
        System.Console.WriteLine("CriarContaPessoaJuridica");
        // CriarContaPessoaJuridica()
      }
      else
      {
        System.Console.WriteLine("Digite uma opção valida!");
      }
    }

    public Cliente BuscarClientePorNumeroDeConta(int numeroConta)
    {
      return _listaClientes.Find(cliente => cliente.NumeroConta == numeroConta);
    }

    public void ExibirClientes()
    {
      System.Console.WriteLine("Lista de Clientes: ");
      System.Console.WriteLine();
      foreach (var cliente in _listaClientes)
      {
        System.Console.WriteLine(cliente.ResumoCliente());
      }
    }
  }
}