using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_07
{
  public class ContaBancaria
  {
    public int NumeroDaConta { get; set; }
    private const decimal SaldoMaximo = 5000;

    private decimal Saldo { get; set; }

    public void Depositar(decimal valor)
    {
      if (valor > 0 && valor <= SaldoMaximo)
      {
        Saldo += valor;
        System.Console.WriteLine("Depósito Realizado com sucesso. Saldo atual de : " + Saldo);
      }
      else
      {
        System.Console.WriteLine("Valor invalido para depósito!");
      }
    }
    public void Sacar(decimal valor)
    {
      if (valor > 0 && Saldo >= valor)
      {
        Saldo -= valor;
        System.Console.WriteLine("Saque Realizado com sucesso. Saldo atual de : " + Saldo);
      }
      else
      {
        System.Console.WriteLine("Valor invalido para Saque!");
      }
    }

  }
}