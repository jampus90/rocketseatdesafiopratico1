namespace DesafioPraticoRS1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var apresentacaoService = new Apresentacao();
            var operacoesService = new OperacoesMatematicas();

            Console.WriteLine("Escolha o exercício que deseja rodar:");
            Console.WriteLine("1. Mensagem de boas vindas ao digitar o nome");
            Console.WriteLine("2. Concatenar nome e sobrenome inserido pelo usuario");
            Console.WriteLine("3. Programa que faz operações com 2 valores do tipo double");
            Console.WriteLine("4. Programa que conta quantidade de caracteres inseridos");
            Console.WriteLine("5. Programa para verificar placa de carro, seguindo padrão de 2018");
            Console.WriteLine("6. Programa de exibição de data");

            int exercicio = int.Parse(Console.ReadLine());
            switch (exercicio) {
                case 1:
                    string nome  = apresentacaoService.PerguntaNome();
                    apresentacaoService.BemVindo(nome);
                    break;
                case 2:
                    string nome2 = apresentacaoService.PerguntaNome();
                    string sobrenome = apresentacaoService.PerguntaSobrenome();
                    apresentacaoService.ConcatenaNomeSobrenome(nome2, sobrenome);
                    break;
                case 3:
                    Console.WriteLine(operacoesService.SomaDouble(13.4, 6.987));
                    Console.WriteLine(operacoesService.SubtraiDouble(15.0, 60.0));
                    Console.WriteLine(operacoesService.MultiplicaDouble(13.48, 90.002));
                    Console.WriteLine(operacoesService.DivideDouble(2.98, 15));
                    Console.WriteLine(operacoesService.MediaDouble(10, 6.98));
                    break;
            }
        }
    }
}
