


using Banklib.Contas; 
using System;

namespace BancoLib{
    class BankGui
    {
        int escolha = int.Parse(Console.ReadLine());

        public static void BankGuiMain()
        {
            Console.Clear();
                // essa merda demorou 4 horas pra fazer, e ainda tem uns bugs, mas ta ai, o BankGui Banco, o seu banco digital!
        bool running = true;
        while (running) {
            Console.WriteLine($"Hora atual: {ClientesContas.VerHioras()}");
            Console.WriteLine("Bem-vindo ao BankGui o seu banco digital!");
            Console.WriteLine("1. Criar nova conta");
            Console.WriteLine("2. Entrar Na Conta");
            Console.WriteLine("3. Verificar Saldo");
            Console.WriteLine("4. Depositar");
            Console.WriteLine("5. Sacar");
            Console.WriteLine("6. Sair");
            Console.Write("Escolha uma opção: ");
            if (int.TryParse(Console.ReadLine(), out int escolha)) {
                switch (escolha) {
                    case 1:
                    ClientesContas.CriarConta();
                    ClientesContas.CriarConta("Qualquer dúvida, estamos aqui para ajudar! so entrar em contato conosco. no numero (11) 99999-9999 ou no email bankgui@banco.com");


                        break;
                    case 2:
                        ClientesContas.EntrarNaConta();

                        
                        break;
                    case 3:
                        ClientesContas.VerificarSaldo();

                        break;
                    case 4:
                        ClientesContas.Depositar();
  
                        break;
                    case 5:
                        ClientesContas.Sacar();

                        break;
                    case 6:

                        running = false;
                        Console.WriteLine("Obrigado por usar o BankGui Banco. Até logo!");
                        Console.WriteLine($"Hora atual: {ClientesContas.VerHioras()}");

                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            } else {
                Console.WriteLine("Entrada inválida. Por favor, digite um número.");
            }
    }
}
    }}