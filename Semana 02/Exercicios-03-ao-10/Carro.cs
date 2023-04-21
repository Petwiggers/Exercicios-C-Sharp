using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_03_ao_10
{
  public class Carro
  {
    public string Marca;
    public string Modelo;
    public string Ano;
    public string Placa;
    public string Cor;
    public Proprietario Proprietario;

    public Carro(string marca, string modelo, string ano, string placa, string cor, Proprietario proprietario)
    {
      Marca = marca;
      Modelo = modelo;
      Ano = ano;
      Placa = placa;
      Cor = cor;
      Proprietario = proprietario;
    }
  }
}