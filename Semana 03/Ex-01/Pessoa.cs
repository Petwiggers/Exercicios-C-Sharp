using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_01
{
  public class Pessoa
  {
    private String Nome;
    protected int Idade;
    public String Endereco;

    public Pessoa(String nome, int idade, String endereco)
    {
      Nome = nome;
      Idade = idade;
      Endereco = endereco;
    }

    public void Saudacao()
    {
      System.Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho {Idade} anos!");
    }
  }
}