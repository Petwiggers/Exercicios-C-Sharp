internal class Program
{
  private static void Main(string[] args)
  {
    double soma = 0, media;
    int tamanhoArray;
    System.Console.Write("Digite a quantidade de números que deseja calcular a média: ");
    tamanhoArray = int.Parse(Console.ReadLine());
    double[] numeros = new double[tamanhoArray];
    for (int i = 0; i < numeros.Length; i++)
    {
      System.Console.Write($"Digite o {i + 1} numero :");
      numeros[i] = double.Parse(Console.ReadLine());
    }
    foreach (var item in numeros)
    {
      soma += item;
    }
    media = soma / numeros.Length;
    System.Console.WriteLine("A média aritmética dos números é " + media);
  }
}