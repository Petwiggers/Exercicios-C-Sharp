using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_04
{
  public class ContaBancaria
  {
    private double _saldo;

    public double Saldo2
    {
      get { return _saldo; }
      private set { _saldo = value; }
    }
    public void Depositar(double valor)
    {
      if (valor > 0)
      {
        Saldo2 += valor;
        Console.WriteLine($"Você depositou R${valor} na sua conta !");
      }
      else
      {
        Console.WriteLine("Você só pode depositar um valor maior que 0 !");
      }
    }
    public bool Sacar(double valor)
    {
      if ((valor <= _saldo) && (valor > 0))
      {
        Saldo2 -= valor;
        Console.WriteLine($"Você sacou R${valor} da sua conta !");
        return true;
      }
      else
      {
        Console.WriteLine("Valor Inválido!");
        return false;
      }
    }
  }
}