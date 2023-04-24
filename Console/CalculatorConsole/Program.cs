using System;

namespace CalculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;

            while (true)
            {

                Console.Write("Indique o primeiro dígito: ");
                string str_num1 = Console.ReadLine();
                if (!double.TryParse(str_num1, out double num1))
                {
                    Console.WriteLine("Valor intorduzido inválido");
                    continue;
                }


                Console.Write("Indique o segundo dígito: ");
                string str_num2 = Console.ReadLine();
                if (!double.TryParse(str_num2, out double num2))
                {
                    Console.WriteLine("Valor intorduzido inválido");
                    continue;
                }


                Console.WriteLine("Indique a opção");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Substração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("-1 - Sair");
                opcao = Console.ReadLine();
                
                double result;
                string operacao;
                switch (opcao)
                {
                    case "1":
                        {
                            result = num1 + num2;
                            operacao = "+";
                            break;
                        }
                    case "2:":
                        {
                            result = num1 - num2;
                            operacao = "-";
                            break;
                        }
                    case "3:":
                        {
                            result = num1 * num2;
                            operacao = "*";
                            break;
                        }
                    case "4:":
                        {
                            if (num2 == 0)
                            {
                                Console.WriteLine("Não é possível a divisão por 0");
                                continue;
                            }

                            operacao = "/";
                            result = num1 / num2;

                            break;
                        }
                    case "-1":
                        return;
                    default:
                        {
                            Console.WriteLine("OPção inválida!");
                            continue;
                        }
                }

                Console.WriteLine("-------------------------------------");
                Console.WriteLine(@$"{num1} {operacao} {num2} = {result}");
            }
        }
    }
}
