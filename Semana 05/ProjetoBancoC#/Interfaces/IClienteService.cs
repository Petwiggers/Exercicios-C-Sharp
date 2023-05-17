using ProjetoBancoC_.Models;

namespace ProjetoBancoC_.Interfaces
{
  public interface IClienteService
  {
    void CriarConta();
    Cliente BuscarClientePorNumeroDeConta(int numeroConta);
    void ExibirClientes();
    void CriarContaPessoaFisica();
    void CriarContaPessoaJuridica();
  }
}