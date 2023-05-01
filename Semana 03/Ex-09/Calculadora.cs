using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_09
{
  public static class Calculadora
  {
    public const double Pi = 3.14159;

    public static double Soma(double a, double b)
    {
      return a + b;
    }
    public static double Subracao(double a, double b)
    {
      return a - b;
    }
    public static double Multiplicacao(double a, double b)
    {
      return a * b;
    }
    public static double Divisao(double a, double b)
    {
      if (b == 0)
      {
        System.Console.WriteLine("Não é possivel realizar uma divisão por 0!");

      }
      return a / b;
    }
  }
}