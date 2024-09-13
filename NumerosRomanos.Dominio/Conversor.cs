using System.Linq;

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

    public int Calcular(string numeroRomano)
    {
        int resultadoFinal = 0;
        var numerosRomanosCharArray = numeroRomano.ToCharArray();
        int numeroAtual;
        int pivoCentral = 0;
        int i = 0;
        int aux = 0;
        int proximoNumero=0;


        for (i = 0; i < numerosRomanosCharArray.Length; i++)
        {
            numeroAtual = ConverterNumeros(Convert.ToString(numerosRomanosCharArray[i]));

            aux = numeroAtual;

            if (i != (numerosRomanosCharArray.Length - 1))
            {
                 proximoNumero = ConverterNumeros(Convert.ToString(numerosRomanosCharArray[i + 1]));
            }
            if (proximoNumero > numeroAtual)
                resultadoFinal -= aux;
            else
            {
                aux = numeroAtual;
                resultadoFinal += aux;
                pivoCentral = i;
            }


        }

        //if (numerosRomanosCharArray[i] < numerosRomanosCharArray[pivoCentral])
        //{
        //    resultadoFinal -= valor;
        //}
        //else
        //{
        //    resultadoFinal += valor;
        //}





        return resultadoFinal;
    }
}