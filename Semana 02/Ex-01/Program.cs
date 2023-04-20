internal class Program
{
  private static void Main(string[] args)
  {
    System.Console.WriteLine("Soma de dois vaçores Int: " + SomarValores(2, 3));
    System.Console.WriteLine("Soma de dois vaçores Double: " + SomarValores(10.0, 12.5));
    System.Console.WriteLine("Soma de três vaçores Double: " + SomarValores(10.0, 12.5, 20.22));
  }
  private static int SomarValores(int numero1, int numero2)
  {
    return numero1 + numero2;
  }
  private static double SomarValores(double numero1, double numero2)
  {
    return numero1 + numero2;
  }
  private static double SomarValores(double numero1, double numero2, double numero3)
  {
    return numero1 + numero2 + numero3;
  }
}