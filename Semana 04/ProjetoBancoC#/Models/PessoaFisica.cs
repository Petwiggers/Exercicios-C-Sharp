
namespace ProjetoBancoC_.Models
{
  public class PessoaFisica : Cliente
  {
    public string Cpf { get; set; }
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }

    public PessoaFisica(string numeroConta, string endereco, string cpf, string nome, DateTime dataNascimento) : base(numeroConta, endereco)
    {
      Cpf = cpf;
      Nome = nome;
      DataNascimento = dataNascimento;
    }

    public bool EhMaior()
    {
      var idade = DateTime.Now.Year - DataNascimento.Year;
      if (!(DateTime.Now.Month >= DataNascimento.Month
          && DateTime.Now.Day >= DataNascimento.Day))
      {
        idade--;
      }
      return idade >= 18;
    }

    public override void ResumoCliente()
    {
      System.Console.WriteLine($"Conta: {NumeroConta}\nSaldo: {Saldo}\nEndereço: {Endereco}\nCpf: {Cpf}\nNome: {Nome}\nData Nascimento: {DataNascimento}");
    }
  }
}