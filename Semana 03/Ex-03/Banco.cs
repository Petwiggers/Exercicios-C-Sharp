using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03
{
  public class Banco
  {
    private double _saldo;

    public void Depositar(double valor)
    {
      if (valor > 0)
      {
        _saldo += valor;
        Console.WriteLine($"Você depositou R${valor} na sua conta !");
      }
      else
      {
        Console.WriteLine("Você só pode depositar um valor maior que 0 !");
      }
    }
    public void Sacar(double valor)
    {
      if ((valor <= _saldo) && (valor > 0))
      {
        _saldo -= valor;
        Console.WriteLine($"Você sacou R${valor} da sua conta !");
      }
      else
      {
        Console.WriteLine("Valor Inválido!");
      }
    }

    public string ToString()
    {
      return $"Saldo: {_saldo}";
    }
  }
}