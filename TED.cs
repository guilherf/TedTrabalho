using MediaAluno;
using LibrariaIMC;
using CalcularMenu;
using TabuadaPersonalizada;
using CondicaodeParada;
using SenhaValida;
using TemperaturasConverter;
     class TED
    {
        static void Main(string[] args)
        {
            bool mostrarConsole = true;
            while (mostrarConsole)
        {
            Console.Clear( );
            Console.WriteLine("================================================");
            Console.WriteLine("=              TED FACULDADE                   =");
            Console.WriteLine("================================================");
            Console.WriteLine("1 Calcular Média");
            Console.WriteLine("2 Classificador de indice Corporal (IMC)");
            Console.WriteLine("3 Calculadora");
            Console.WriteLine("4 Gerador de Tabuada Personalizada");
            Console.WriteLine("5 Somador com Condição de Parada");
            Console.WriteLine("6 Sistema de Validação de Senha");
            Console.WriteLine("7 Conversor de Temperaturas Universal");
            Console.WriteLine("8 Mini Simulador de Caixa Eletrônico");
            Console.WriteLine("0 sair");
            Console.WriteLine("================================================");
            Console.Write("Escolha uma opção: ");
            if (int.TryParse(Console.ReadLine(), out int opcao))
            {

            
            switch (opcao)
            {
                case 1:
                CalcularMedia.CalcularMediaAluno();
                    break;
                case 2:
                
                LibrariaIMC.ClassificarCorporalIMC.ClassificarIMC();
                    break;
                case 3:
                CalcularMenu.MenuCalcular.CalculoMenu();
                    break;
                case 4:
                TabuadaPersonalizada.Tabuada.GerarTabuada();
                    break;
                case 5:
                CondicaodeParada.CondicaodeParadaVerificar.VerificarCondicao();
                    break;
                case 6:
                SenhaValida.ValidarSenha.VerificarSenha();
                    break;
                case 7:
                TemperaturasConverter.ConversorTemperaturasUniversais.ConverterTemperaturas();
                    break;
                case 8:
                BancoLib.BankGui.BankGuiMain();

                    break;
                case 0:
                    mostrarConsole = false;
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Pressione Enter para tentar novamente.");
                    Console.ReadLine();
                    break;
                } 
            
            } 
        }

    }
}