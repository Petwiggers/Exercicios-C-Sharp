using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_02
{
  public class ContaBancaria
  {
    private int NumeroConta { get; set; }
    private double Saldo { get; set; }

    public ContaBancaria()
    {
      Saldo = 0;
      NumeroConta = new Random().Next();
    }

    public void Deposita(double valor)
    {
      if (valor > 0)
      {
        Saldo += valor;
        Console.WriteLine($"Você depositou R${valor} na sua conta !");
      }
      else
      {
        Console.WriteLine("Você só pode depositar um valor maior que 0 !");
      }
    }

    public void Sacar(double valor)
    {
      if ((valor <= Saldo) && (valor > 0))
      {
        Saldo -= valor;
        Console.WriteLine($"Você sacou R${valor} da sua conta !");
      }
      else
      {
        Console.WriteLine("Valor Inválido!");
      }
    }

    public void getSaldo()
    {
      System.Console.WriteLine($"Você possui um Saldo de: R${Saldo}");
    }
  }
}