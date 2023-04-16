internal class Program
{
  private static void Main(string[] args)
  {
    int[] numeros = new int[4];

    for (int i = 0; i < 4; i++)
    {
      Console.Write("Digite o " + (i + 1) + " número: ");
      numeros[i] = int.Parse(Console.ReadLine());
    }
    Array.Sort(numeros);

    foreach (var item in numeros)
    {
      Console.WriteLine($"{item}  ");
    }
  }
}