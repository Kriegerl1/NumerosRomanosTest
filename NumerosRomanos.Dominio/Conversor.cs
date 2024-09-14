using System.Drawing;
using System.Linq;
using System.Text;

namespace NumerosRomanos.Dominio;

public class Conversor
{
    public Conversor()
    { }

    public int ConverterNumeros(string numeroRomano)
    {
        int Resultado = 0;
        var a = numeroRomano.ToCharArray();

        for (int i = 0; i < a.Length; i++)
            switch (a[i])
            {
                case 'I':
                    return Resultado = 1;
                case 'V':
                    return Resultado = 5;
                case 'X':
                    return Resultado = 10;
                case 'L':
                    return Resultado = 50;
                case 'C':
                    return Resultado = 100;
                case 'D':
                    return Resultado = 500;
                case 'M':
                    return Resultado = 1000;
            }

        return Resultado = 0;
    }
    public string ConverterRomanos(int numero)
    {
        string Resultado;

        switch (numero)
        {
            case 1:
                return Resultado = "I";
            case 5:
                return Resultado = "V";
            case 10:
                return Resultado = "X";
            case 50:
                return Resultado = "L";
            case 100:
                return Resultado = "C";
            case 500:
                return Resultado = "D";
            case 1000:
                return Resultado = "M";

        }



        return Resultado = string.Empty;
    }

    public string CalcularInverso(int Numero)
    {
        //99 = XCIX
        string resultadoFinal = string.Empty;

        var numerais = new[]
        {
        new { Valor = 1000, Simbolo = "M" },
        new { Valor = 900, Simbolo = "CM" },
        new { Valor = 500, Simbolo = "D" },
        new { Valor = 400, Simbolo = "CD" },
        new { Valor = 100, Simbolo = "C" },
        new { Valor = 90, Simbolo = "XC" },
        new { Valor = 50, Simbolo = "L" },
        new { Valor = 40, Simbolo = "XL" },
        new { Valor = 10, Simbolo = "X" },
        new { Valor = 9, Simbolo = "IX" },
        new { Valor = 5, Simbolo = "V" },
        new { Valor = 4, Simbolo = "IV" },
        new { Valor = 1, Simbolo = "I" }
    };

        foreach (var i in numerais)
            if (Numero >= i.Valor)
            {
                resultadoFinal += i.Simbolo;
                Numero -= i.Valor;
            };

        return resultadoFinal;

    }
    public int Calcular(string numeroRomano)
    {
        char[] numerosRomanosCharArray = numeroRomano.ToCharArray();
        int resultadoFinal = 0, numeroAtual, proximoNumero = 0;


        for (int i = 0; i < numerosRomanosCharArray.Length; i++)
        {
            numeroAtual = ConverterNumeros(Convert.ToString(numerosRomanosCharArray[i]));

            int aux = numeroAtual;

            if (i != (numerosRomanosCharArray.Length - 1))
                proximoNumero = ConverterNumeros(Convert.ToString(numerosRomanosCharArray[i + 1]));

            if (proximoNumero > numeroAtual)
                resultadoFinal -= aux;
            else
                resultadoFinal += aux;
        }

        return resultadoFinal;
    }
}