using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExSemana06
{
  public class Soma
  {
    public List<int> numeros = new List<int> { 1, 9, 4, 6, 8 };

    public static int Somar(List<int> numeros)
    {
      int resultado = 0;
      foreach (var item in numeros)
      {
        resultado += item;
      }
      return resultado;
    }
  }
}