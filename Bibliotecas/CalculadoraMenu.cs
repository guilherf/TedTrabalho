namespace CalcularMenu
{
    public class MenuCalcular
    {
        public static void CalculoMenu()
        {
            Console.WriteLine("Bem-vindo à Calculadora");
            bool mostrarConsole = true;
            do
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1. Soma");
                Console.WriteLine("2. Subtração");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");
                Console.WriteLine("0. Voltar ao menu principal");
            

                Console.Write("Digite sua opção: ");
                int opcao = int.TryParse(Console.ReadLine(), out opcao) ? opcao : -1;
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Você escolheu Soma.");
                        Console.Write("Digite o primeiro número: ");
                        double num1 = double.TryParse(Console.ReadLine(), out num1) ? num1 : 0;
                        Console.Write("Digite o segundo número: ");
                        double num2 = double.TryParse(Console.ReadLine(), out num2) ? num2 : 0;
                        double resultadoSoma = num1 + num2;
                        Console.WriteLine($"Resultado: {num1} + {num2} = {resultadoSoma}");
                        break;
                    case 2:
                        Console.WriteLine("Você escolheu Subtração.");
                        Console.Write("Digite o primeiro número: ");
                        double num3 = double.TryParse(Console.ReadLine(), out num3) ? num3 : 0;
                        Console.Write("Digite o segundo número: ");
                        double num4 = double.TryParse(Console.ReadLine(), out num4) ? num4 : 0;
                        double resultadoSubtracao = num3 - num4;
                        Console.WriteLine($"Resultado: {num3} - {num4} = {resultadoSubtracao}");
                        break;
                    case 3:
                        Console.WriteLine("Você escolheu Multiplicação.");
                        Console.Write("Digite o primeiro número: ");
                        double num5 = double.TryParse(Console.ReadLine(), out num5) ? num5 : 0;
                        Console.Write("Digite o segundo número: ");
                        double num6 = double.TryParse(Console.ReadLine(), out num6) ? num6 : 0;
                        double resultadoMultiplicacao = num5 * num6;
                        Console.WriteLine($"Resultado: {num5} * {num6} = {resultadoMultiplicacao}");
                        break;
                    case 4:
                        Console.WriteLine("Você escolheu Divisão.");
                        Console.Write("Digite o primeiro número: ");
                        double num7 = double.TryParse(Console.ReadLine(), out num7) ? num7
                            : 0;
                        Console.Write("Digite o segundo número: "); 
                        double num8 = double.TryParse(Console.ReadLine(), out num8) ? num8 : 0;
                        if (num8 != 0)
                        {
                            double resultadoDivisao = num7 / num8;
                            Console.WriteLine($"Resultado: {num7} / {num8} = {resultadoDivisao}");
                        }
                        else
                        {
                            Console.WriteLine("Erro: Divisão por zero não é permitida.");
                        }
                        break;
                    case 0:
                        mostrarConsole = false;
                        Console.WriteLine("Voltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Por favor, tente novamente.");
                        break;
                }    

                } while (!mostrarConsole);
                Console.WriteLine("Pressione Enter para continuar...");
                Console.ReadLine();       




        }
    
}
}