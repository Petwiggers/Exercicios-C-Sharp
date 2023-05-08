using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBancoC_.Models
{
  public abstract class Cliente
  {
    public string NumeroConta { get; set; }
    public decimal Saldo { get; set; }
    public string Endereco { get; set; }

    public void ResumoCliente()
    {
      System.Console.WriteLine($"Conta: {NumeroConta}\nSaldo: {Saldo}\nEndereço: {Endereco}");
    }

  }
}