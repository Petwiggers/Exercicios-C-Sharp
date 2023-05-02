using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_10
{
  public class ContaBancaria
  {
    public double SaldoDaConta { get; private set; }
    private List<string> Transacoes = new List<string>();

    public void Depositar(double valor)
    {
      if (valor > 0)
      {
        SaldoDaConta += valor;
        Transacoes.Add("Foi depositado R$ " + valor + " na sa conta");
      }
    }

    public bool Sacar(double valor)
    {
      if (valor > 0 && valor <= SaldoDaConta)
      {
        SaldoDaConta -= valor;
        Transacoes.Add("Foi Sacado R$ " + valor + " da sua conta");
        return true;
      }
      return false;

    }
    public void MostrarSaldo()
    {
      System.Console.WriteLine($"Seu Saldo atual é de {SaldoDaConta}");
    }

    public void Extrato()
    {
      System.Console.WriteLine("Seu Extrato da conta :\n");
      foreach (var item in Transacoes)
      {
        System.Console.WriteLine(item);
      }
      System.Console.WriteLine("\nSaldo atual de : " + SaldoDaConta);
    }
  }
}