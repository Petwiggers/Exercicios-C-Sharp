using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_06
{
  public class Retangulo
  {
    private double _largura;
    private double _altura;

    public double Largura
    {
      get { return _largura; }
      private set { _largura = value; }
    }

    public double Altura
    {
      get { return _altura; }
      private set { _altura = value; }
    }

    public void DefinirAltura(double altura)
    {
      if (altura > 0)
      {
        Altura = altura;
      }
      else
      {
        System.Console.WriteLine("A altura deve ser um valor positivo !");
      }
    }

    public void DefinirLargura(double largura)
    {
      if (largura > 0)
      {
        Largura = largura;
      }
      else
      {
        System.Console.WriteLine("A largura deve ser um valor positivo !");
      }
    }
    public void GetRetangulo()
    {
      System.Console.WriteLine($"O Retangulo possui: \n\nAltura: {_altura}\nLargura: {_largura}");
      System.Console.WriteLine($"Area: {_largura * _altura}");
    }
  }
}