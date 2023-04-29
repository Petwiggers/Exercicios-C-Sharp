using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_03
{
  public class Cliente
  {
    private string _nome;
    private string _cpf;

    public Cliente(string nome, string cpf)
    {
      _nome = nome;
      _cpf = cpf;
    }

    public override String ToString()
    {
      return $"Nome: {_nome}\nCpf: {_cpf}";
    }
  }
}