internal class Program
{
  private static void Main(string[] args)
  {
    char operacao;
    double numero1, numero2, resultado = 0;
    bool sair = false;
    do
    {
      System.Console.WriteLine("+ = Adição");
      System.Console.WriteLine("- = Subtração");
      System.Console.WriteLine("* = Multiplicação");
      System.Console.WriteLine("/ = Divisão");
      System.Console.WriteLine("X = Sair\n");
      System.Console.Write("Digite qual operação deseja realizar: ");
      operacao = char.Parse(Console.ReadLine());
      if (operacao == 'X')
      {
        sair = true;
      }
      else if (operacao != '+' && operacao != '-' && operacao != '*' && operacao != '/')
      {
        System.Console.WriteLine("Operação inválida tente novamente !");
      }
      else
      {
        System.Console.Write("Digite o primeiro número :");
        numero1 = double.Parse(Console.ReadLine());
        System.Console.Write("Digite o segundo número :");
        numero2 = double.Parse(Console.ReadLine());

        if (operacao == '/' && numero2 == 0)
        {
          System.Console.WriteLine("Não é possivel dividir um número por 0 !\n\n");
        }
        else
        {
          switch (operacao)
          {
            case '+':
              resultado = numero1 + numero2;
              break;
            case '-':
              resultado = numero1 - numero2;
              break;
            case '*':
              resultado = numero1 * numero2;
              break;
            case '/':
              resultado = numero1 / numero2;
              break;
          }
          System.Console.WriteLine($"{numero1} {operacao} {numero2} = {resultado} \n\n");
        }
      }
    } while (!sair);

  }
}