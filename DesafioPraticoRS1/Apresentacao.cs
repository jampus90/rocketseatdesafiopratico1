using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPraticoRS1;
public class Apresentacao
{
    public string PerguntaNome()
    {
        Console.WriteLine("Qual seu nome?");
        string nome = Console.ReadLine();
        return nome;
    }
    public string PerguntaSobrenome()
    {
        Console.WriteLine("Qual seu sobrenome?");
        string sobrenome = Console.ReadLine();
        return sobrenome;
    }
    public void BemVindo(string nome)
    {
        Console.WriteLine($"Olá {nome}! Seja muito bem vindo!");
    }
    public void ConcatenaNomeSobrenome(string nome, string sobrenome)
    {
        Console.WriteLine($"{nome} {sobrenome}");
    }
}
