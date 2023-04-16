internal partial class Program
{
  private static void Main(string[] args)
  {
    int numero;
    do
    {
      Console.Write("Digite um número positivo : ");
      numero = int.Parse(Console.ReadLine());
      if (numero <= 0)
      {
        Console.WriteLine("O número digitado foi inválido !");
      }
      else
      {
        System.Console.WriteLine("Os números pares até este número digitado são :");
        for (int i = 0; i <= numero; i += 2)
        {
          Console.Write(i + "  ");
        }
      }
    } while (numero <= 0);
  }
}