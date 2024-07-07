namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Average calc = new Average();
            Console.WriteLine("Você quer calcular a média de quantos números?");
            int quant = int.Parse(Console.ReadLine());
            int[] vetor = new int[quant];

            for (int i = 0; i < quant; i++)
            {
                try
                {
                    Console.WriteLine($"Digite o {i + 1}º número: ");
                    int n1 = int.Parse(Console.ReadLine());
                    vetor[i] = n1;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro: entrada inválida. Por favor, digite um número.");
                    i--;
                    continue;
                }

                System.Console.WriteLine("Quer digitar mais um número? (s/n)");
                System.Console.WriteLine($"Tamanho do vetor: {quant}");
                System.Console.WriteLine($"Números digitados: {i + 1}");

                string resposta = Console.ReadLine().ToUpper();
                if (resposta == "S")
                {
                    continue;
                }
                else if (resposta == "N")
                {
                    break;
                }
                else
                {
                    System.Console.WriteLine("Digite um valor válido.");
                    i--;
                }
            }

            Console.WriteLine(calc.CalcularMedia(quant, vetor));
        }
    }
}