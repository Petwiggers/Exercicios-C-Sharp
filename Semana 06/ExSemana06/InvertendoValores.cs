using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExSemana06
{
  public class InvertendoValores
  {
    public static List<int> InverterOrdem(List<int> valores)
    {
      List<int> ListaInvertida = new List<int>();
      for (int i = valores.Count - 1; i >= 0; i--)
      {
        ListaInvertida.Add(valores[i]);
      }
      return ListaInvertida;
    }
  }
}