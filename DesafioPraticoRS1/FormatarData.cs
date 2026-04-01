using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPraticoRS1;
public class FormatarData
{
    public void SolicitaFormatoData()
    {
        DateTime agora = DateTime.Now;

        Console.WriteLine("Escolha o formato de data desejado:");
        Console.WriteLine("1. Formato Completo (Dia da semana, Dia do mês, Mês, Ano, Hora, Minutos, Segundos).");
        Console.WriteLine("2. Apenas a data (01/03/2026).");
        Console.WriteLine("3. Apenas a hora no formato de 24 horas.");
        Console.WriteLine("4. Data com o mês por extenso.");

        int formatoData = int.Parse(Console.ReadLine());

        switch (formatoData)
        {
            case 1:
                Console.WriteLine($"{agora.DayOfWeek}, Mês {agora.Month}, Dia {agora.Day}, Ano {agora.Year}, {agora.Hour} horas, {agora.Minute} minutos, {agora.Second} segundos");
                break;
            case 2:
                Console.WriteLine($"{String.Format("{0:dd/MM/yyy}", agora)}");
                break;
            case 3:
                Console.WriteLine($"{String.Format("{0: HH:mm:ss}", agora)}");
                break;
            case 4:
                Console.WriteLine($"{agora.Day} de {agora.ToString("MMMM", new CultureInfo("pt-BR"))} de {agora.Year}");
                break;
        }
    }
}
