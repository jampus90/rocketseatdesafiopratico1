using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPraticoRS1;
public class ManipulaString
{
    public string DigitaPalavra()
    {
        Console.WriteLine("Digite a palavra desejada.");
        var palavra = Console.ReadLine();
        return palavra;
    }
    public int ContaCaracteres(string palavra)
    {
        return palavra.Count();
    }
}
