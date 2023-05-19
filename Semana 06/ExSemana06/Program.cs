using ExSemana06;


List<int> valores = new List<int>() { 8, 4, 9, 6 };
List<int> listaConvertida = InvertendoValores.Inverter(valores);

foreach (var item in listaConvertida)
{
  System.Console.Write(item + ",");
}
