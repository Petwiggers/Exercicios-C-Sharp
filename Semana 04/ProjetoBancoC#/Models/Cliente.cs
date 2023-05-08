
namespace ProjetoBancoC_.Models
{
  public abstract class Cliente
  {
    public string NumeroConta { get; set; }
    public decimal Saldo { get; set; }
    public string Endereco { get; set; }

    public Cliente(string numeroConta, string endereco)
    {
      NumeroConta = numeroConta;
      Endereco = endereco;
      Saldo = 0;
    }

    public virtual void ResumoCliente()
    {
      System.Console.WriteLine($"Conta: {NumeroConta}\nSaldo: {Saldo}\nEndereço: {Endereco}");
    }

  }
}