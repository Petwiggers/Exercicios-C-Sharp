internal class Program
{
  private static void Main(string[] args)
  {
    int numero1, numero2;
    Console.Write("Digite o Primeiro número: ");
    numero1 = int.Parse(Console.ReadLine());
    Console.Write("Digite o Primeiro número: ");
    numero2 = int.Parse(Console.ReadLine());

    Console.WriteLine("A soma dos dois números é " + (numero1 + numero2));
  }
}