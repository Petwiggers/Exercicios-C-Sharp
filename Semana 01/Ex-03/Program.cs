internal class Program
{
  private static void Main(string[] args)
  {
    string nome;
    int idade;
    System.Console.Write("Digite a seu nome: ");
    nome = Console.ReadLine();
    System.Console.Write("Digite a sua idade:");
    idade = int.Parse(Console.ReadLine());

    if (idade > 0 && idade < 18)
    {
      System.Console.WriteLine($"{nome} é menor de idade !");
    }
    else if (idade >= 18 && idade < 65)
    {
      System.Console.WriteLine($"{nome} é maior de idade !");
    }
    else if (idade >= 65 && idade < 135)
    {
      System.Console.WriteLine($"{nome} você é idoso(a) !");
    }
    else
    {
      System.Console.WriteLine("A idade digitada é inválida !");
    }

  }
}