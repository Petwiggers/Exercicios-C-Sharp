internal class Program
{
  private static void Main(string[] args)
  {
    int numero;

    Console.Write("Digite um número inteiro: ");
    numero = int.Parse(Console.ReadLine());
    if (numero % 2 == 0)
    {
      System.Console.WriteLine("O número digitado é Par !");
    }
    else
    {
      System.Console.WriteLine("O número digitado é Ímpar !");
    }
  }
}