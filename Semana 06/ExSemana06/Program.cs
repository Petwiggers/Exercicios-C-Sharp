using ExSemana06;


List<int> valores = new List<int>() { 8, 4, 9, 6 };
List<int> valores2 = new List<int>() { 8, 4, 9, 6 };
List<int> listaOrdenada = Ordenar.Inverter(valores);
List<int> listaInvertida = InvertendoValores.InverterOrdem(valores2);
foreach (var item in listaInvertida)
{
  System.Console.WriteLine(item);
}
System.Console.WriteLine();
System.Console.WriteLine();
foreach (var item in listaOrdenada)
{
  System.Console.WriteLine(item);
}
