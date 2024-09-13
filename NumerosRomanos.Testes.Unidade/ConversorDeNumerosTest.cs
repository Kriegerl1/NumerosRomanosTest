using NumerosRomanos.Dominio;

namespace NumerosRomanos.Testes.Unidade;

[TestClass]
[TestCategory("Unidade")]
public class ConversorDeNumerosTest
{
    readonly Conversor _conversor = new();


    [TestMethod]
    [DataRow("I", 1)]
    [DataRow("V", 5)]
    [DataRow("X", 10)]
    [DataRow("L", 50)]
    [DataRow("C", 100)]
    [DataRow("D", 500)]
    [DataRow("M", 1000)]
    public void Deve_Converter_Unidades(string Letra, int Numero)
    {
        //Arrange

        //Act
        var resultadoNumero = _conversor.ConverterRomanos(Numero);

        var resultadoRomanos = _conversor.ConverterNumeros(Letra);


        //Assert
        Assert.AreEqual(Numero, resultadoRomanos);

        Assert.AreEqual(Letra, resultadoNumero);
    }

    [TestMethod]
    //[DataRow("XV", 15)]
    //[DataRow("IV", 4)]
    //[DataRow("VI", 6)]
    [DataRow("XXIV", 24)]
    public void Deve_Calcular_Unidade_Convertida(string Letra, int Numero)
    {
        //Arrange

        //Act
        //var resultadoNumero = _conversor.Calcular(Numero);

        var resultadoRomanos = _conversor.Calcular(Letra);


        //Assert
        Assert.AreEqual(Numero, resultadoRomanos);

        //Assert.AreEqual(Letra, resultadoNumero);
    }
}