using System.Text.RegularExpressions;

namespace DesafioPraticoRS1;
public class PlacaVeiculo
{
    public string DigitaPlaca()
    {
        Console.WriteLine("Digite a sua placa");
        var placa = Console.ReadLine();
        bool valido = VerificaPlaca(placa);

        if (!valido) return "Falso";
        return "Verdadeiro";
    }
    private bool VerificaPlaca(string placa)
    {
        if (placa == null) return false;

        if (placa.Length != 7) return false;

        var padraoNormal = new Regex("[a-zA-Z]{3}[0-9]{4}");
        return padraoNormal.IsMatch(placa);
    }
}
