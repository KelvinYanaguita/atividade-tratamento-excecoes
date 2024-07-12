using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Average calc = new Average();
            bool continuar = true;

            while (continuar)
            {
                double quant = 0;
                int tamanho = 0;
                double[] vetor = null;

                while (true)
                {
                    try
                    {
                        Console.WriteLine("Você quer calcular a média de quantos números?");
                        string quantidade = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(quantidade))
                        {
                            Console.WriteLine("Erro: entrada vazia. Por favor, digite um número.");
                            continue; // Re-prompt for input
                        }

                        quant = double.Parse(quantidade);

                        if (quant <= 0)
                        {
                            Console.WriteLine("Erro: o número deve ser maior que zero.");
                            continue; // Re-prompt for input
                        }

                        tamanho = (int)quant;
                        vetor = new double[tamanho];
                        break; // Sair do loop se a entrada for válida
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Erro: entrada inválida. Por favor, digite um número válido.");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Erro: número muito grande para ser processado.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro inesperado: {ex.Message}");
                    }
                }

                int i = 0;

                while (i < tamanho)
                {
                    try
                    {
                        Console.WriteLine($"Digite o {i + 1}º número:");
                        string input = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(input))
                        {
                            Console.WriteLine("Erro: entrada vazia. Por favor, digite um número.");
                            continue; // Re-prompt for input
                        }

                        vetor[i] = double.Parse(input);
                        i++;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Erro: entrada inválida. Por favor, digite um número válido.");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Erro: número muito grande para ser processado.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro inesperado: {ex.Message}");
                    }

                    if (i < tamanho)
                    {
                        Console.WriteLine("Quer digitar mais um número? (s/n)");
                        Console.WriteLine($"Tamanho do vetor: {quant}");
                        Console.WriteLine($"Números digitados: {i}");

                        string resposta = Console.ReadLine().ToUpper();

                        while (resposta != "S" && resposta != "N")
                        {
                            Console.WriteLine("ERRO: Digite um valor válido (S ou N).");
                            resposta = Console.ReadLine().ToUpper();
                        }

                        if (resposta == "S")
                        {
                            continue; // Continuar no loop para digitar mais números
                        }
                        else if (resposta == "N")
                        {
                            break; // Sair do loop principal
                        }
                    }
                    else
                    {
                        Console.WriteLine("Todos os números foram inseridos.");
                        break; // Sair do loop pois já foram inseridos todos os números
                    }
                }

                Console.WriteLine($"A média é: {calc.CalcularMedia(vetor)}");

                Console.WriteLine("Deseja calcular a média novamente? (S/N)");
                string continuarResposta = Console.ReadLine().ToUpper();

                while (continuarResposta != "S" && continuarResposta != "N")
                {
                    Console.WriteLine("ERRO: Digite um valor válido (S ou N).");
                    continuarResposta = Console.ReadLine().ToUpper();
                }

                if (continuarResposta == "N")
                {
                    continuar = false;
                }
            }

            Console.WriteLine("Encerrando o programa. Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
