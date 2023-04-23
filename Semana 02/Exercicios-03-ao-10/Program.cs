using Exercicios_03_ao_10;

internal class Program
{
  private static void Main(string[] args)
  {
    Proprietario proprietario1 = new Proprietario("Joana", "01523177709", "478767425");
    Proprietario proprietario2 = new Proprietario("Peterson", "01523178809", "498785225");
    Proprietario proprietario3 = new Proprietario("Ricardo", "01323177809", "478785225");

    Carro carro1 = new Carro("Seat", "Cordoba SXE 1.8 / GLX 1.8 4p", "1995", "KIA8858", "Prata", proprietario1);
    Carro carro2 = new Carro("Daihatsu", "Applause 1.6 16V", "1994", "DCD6815", "Amarelo", proprietario2);
    Carro carro3 = new Carro("BMW", "428i Cabriolet Sport 2.0 TB 245cv 2p", "2015", "MYG2480", "Dourado", proprietario3);

    List<Carro> carros = new List<Carro>();
    carros.Add(carro1);
    carros.Add(carro2);
    carros.Add(carro3);


    ListarCarros();
    // void CadastrarCarro()
    // {

    //   Carro carro = new Carro();
    //   System.Console.WriteLine("Digite as informações do carro!");
    //   System.Console.Write("\nMarca: ");
    //   carro.Marca = Console.ReadLine();
    //   System.Console.Write("Modelo: ");
    //   carro.Modelo = Console.ReadLine();
    //   System.Console.WriteLine("Ano:");
    //   carro.Ano = Console.ReadLine();
    //   System.Console.WriteLine("Placa:");
    //   carro.Placa = Console.ReadLine();
    //   System.Console.WriteLine("Cor: ");
    //   carro.Cor = Console.ReadLine();

    //   Proprietario proprietario = new Proprietario();
    //   System.Console.WriteLine("Digite as informações do proprietário !! ");
    //   System.Console.Write("\nNome : ");
    //   proprietario.Nome = Console.ReadLine();
    //   System.Console.Write("Cpf: ");
    //   proprietario.Cpf = Console.ReadLine();
    //   System.Console.Write("Telefone: ");
    //   proprietario.Telefone = Console.ReadLine();

    //   carro.Proprietario = proprietario;
    //   carros.Add(carro);
    // }

    void ListarCarros()
    {
      foreach (var carro in carros)
      {
        System.Console.WriteLine($"\n\nCarro do Proprietário : {carro.Proprietario.Nome}");
        System.Console.WriteLine($"\nMarca : {carro.Marca}");
        System.Console.WriteLine($"Modelo : {carro.Modelo}");
        System.Console.WriteLine($"Ano de fabricaçao : {carro.Ano}");
        System.Console.WriteLine($"Placa do Carro : {carro.Placa}");
        System.Console.WriteLine($"Cor do Carro : {carro.Cor}");
      }
    }
  }
}