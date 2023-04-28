using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03
{
  public class ContaBancaria
  {
    private int _numeroConta;
    private Cliente _cliente;

    private Banco _banco;

    public ContaBancaria(int numeroConta, Cliente cliente)
    {
      _numeroConta = numeroConta;
      _cliente = cliente;
      _banco = new Banco();
    }
    public void ExibirDados()
    {
      System.Console.WriteLine(
          $"Numero da Conta: {_numeroConta}\n" +
          $"{_cliente.ToString()}");
    }

    public void ToString()
    {
      System.Console.WriteLine($"Numero da Conta: {_numeroConta}\n" +
              $"{_cliente.ToString()}\n" +
              $"{_banco.ToString()}");

    }

    public void Depositar(double valor)
    {
      _banco.Depositar(valor);
    }
    public void Sacar(double valor)
    {
      _banco.Sacar(valor);
    }
  }
}