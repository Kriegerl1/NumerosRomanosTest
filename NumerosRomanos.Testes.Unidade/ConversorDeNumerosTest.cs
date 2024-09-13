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
    [DataRow("III", 3)]
    [DataRow("XXX", 30)]
    [DataRow("CCC", 300)]
    [DataRow("MMM", 3000)]
    [DataRow("VIII", 8)]
    [DataRow("LXII", 62)]
    [DataRow("CLVIII", 158)]
    [DataRow("MCXX", 1120)]
    [DataRow("MCXX", 1120)]
    [DataRow("IV", 4)]
    [DataRow("IX", 9)]
    [DataRow("XC", 90)]
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