using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExSemana06
{
  public class InvertendoValores
  {

    public static List<int> Inverter(List<int> valores)
    {
      List<int> valoresInvertidos = new List<int>();
      int valoresCount = valores.Count();
      int menorValor = valores[0];
      int indiceMenorValor = 0;
      for (int i = 0; i < valoresCount; i++)
      {
        for (int j = 0; j < valores.Count(); j++)
        {
          if (j == 0)
          {
            menorValor = valores[j];
            indiceMenorValor = j;
          }
          else if (valores[j] < menorValor)
          {
            menorValor = valores[j];
            indiceMenorValor = j;
          }
        }
        valores.RemoveAt(indiceMenorValor);
        valoresInvertidos.Add(menorValor);
      }

      return valoresInvertidos;
    }



  }
}