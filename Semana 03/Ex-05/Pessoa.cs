using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_05
{
  public class Pessoa
  {
    private string _nome;
    private int _idade;

    public int Idade
    {
      get { return _idade; }
      private set { _idade = value; }
    }

    public Pessoa(string nome)
    {
      _nome = nome;
    }

    public void DefinirIdade(int idade)
    {
      if (idade >= 0)
      {
        Idade = idade;
      }
    }
  }
}