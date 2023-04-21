using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_03_ao_10
{
  public class Proprietario
  {
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Telefone { get; set; }

    public Proprietario() { }
    public Proprietario(string nome, string cpf, string telefone)
    {
      Nome = nome;
      Cpf = cpf;
      Telefone = telefone;
    }
  }


}