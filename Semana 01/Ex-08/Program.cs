internal class Program
{
  private static void Main(string[] args)
  {
    int[] numeros = new int[5];
    int maiorNumero = 0;

    for (int i = 0; i < 5; i++)
    {
      System.Console.Write($"Digite o {i + 1} numero: ");
      numeros[i] = int.Parse(Console.ReadLine());
    }
    for (int i = 0; i < numeros.Length; i++)
    {
      if (numeros[i] > maiorNumero)
      {
        maiorNumero = numeros[i];
      }
    }
    System.Console.WriteLine($"\nO maior número digitado foi {maiorNumero} !");
  }
}