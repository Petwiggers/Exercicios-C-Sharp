internal class Program
{
  private static void Main(string[] args)
  {
    string marca;
    string modelo;
    double kilometragem;

    System.Console.Write("Digite a Marca do seu veículo: ");
    marca = Console.ReadLine();
    System.Console.Write("Digite o modelo dele: ");
    modelo = Console.ReadLine();
    System.Console.Write("Digite a Kilometragem do seu veículo: ");
    kilometragem = double.Parse(Console.ReadLine());
    if (kilometragem < 0)
    {
      System.Console.WriteLine("Kilometragem Inválida !");
      return;
    }
    if (kilometragem > 10000)
    {
      System.Console.WriteLine(
      $"\n\nMarca: {marca}\n" +
      $"Modelo: {modelo}\n" +
      $"Kilometragem: {kilometragem}\n\n" +
      "Você deve fazer uma revisão em seu veículo !"
      );
    }
    else
    {
      System.Console.WriteLine(
      $"\n\nMarca: {marca}\n" +
      $"Modelo: {modelo}\n" +
      $"Kilometragem: {kilometragem}"
      );
    }

  }
}