namespace exercicio.Teste;
using ExSemana06;

public class Tests
{
  [SetUp]
  public void Setup()
  {
  }

  [Test]
  public void TestSoma()
  {
    List<int> numeros = new List<int>() { 1, 2, 3, 8, 9 };
    int resultado = Soma.Somar(numeros);
    int resultadoEsperado = 1 + 2 + 3 + 8 + 9;
    Assert.AreEqual(resultadoEsperado, resultado);
  }
}