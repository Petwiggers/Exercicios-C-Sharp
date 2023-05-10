
namespace ProjetoBancoC_.Models
{
  public abstract class Cliente
  {
    public int NumeroConta { get; set; }
    public decimal Saldo { get; set; }
    public string Endereco { get; set; }

    public Cliente(int numeroConta, string endereco)
    {
      NumeroConta = numeroConta;
      Endereco = endereco;
      Saldo = 0;
    }

    public Cliente()
    {
      Saldo = 0;
    }

    public virtual string ResumoCliente()
    {
      return $"Numero Conta: {NumeroConta} | End: {Endereco} | Saldo: {Saldo.ToString("C2")}";
    }

  }
}