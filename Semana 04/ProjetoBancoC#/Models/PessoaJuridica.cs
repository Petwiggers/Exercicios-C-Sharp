using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBancoC_.Models
{
  public class PessoaJuridica : Cliente
  {
    public string Cnpj { get; set; }
    public string RazaoSocial { get; set; }

    public PessoaJuridica() : base()
    {

    }

    public PessoaJuridica(int numeroConta, string endereco, string cnpj, string razaoSocial) : base(numeroConta, endereco)
    {
      Cnpj = cnpj;
      RazaoSocial = razaoSocial;
    }

    public override string ResumoCliente()
    {
      return $"{base.ResumoCliente()} | Cnpj: {Cnpj} | Razão Social : {RazaoSocial}";
    }
  }
}