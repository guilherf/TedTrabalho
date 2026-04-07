namespace Banklib.Contas
{
    using System;
    using System.IO;
    using System.Linq;
    
    public static class ClientesContas
    {
        private static string CaminhoContas = "contas.txt";
        private static string CaminhoSaldos = "saldos.txt";


        // isso aqui é o metodo de saque, ele vai pedir o nome da conta e a senha, depois ele vai verificar se a conta existe, se existir ele vai pedir o valor a ser sacado, depois ele vai verificar se o saldo é suficiente para o saque, se for suficiente ele vai atualizar o saldo da conta e mostrar o novo saldo para o cliente, se não for suficiente ele vai mostrar uma mensagem de erro.
        // morra IDE.
        public static void Sacar()
        {
            Console.Write("Digite o nome da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a senha da conta: ");
            string senha = Console.ReadLine();
            string conta = $"{nome}:{senha}";
            string[] contas = File.ReadAllLines(CaminhoContas);
            if (contas.Contains(conta))
            {
                Console.Write("Digite o valor a ser sacado: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal valor))
                {
                    string[] saldos = File.ReadAllLines(CaminhoSaldos);
                    int index = Array.FindIndex(saldos, s => s.StartsWith(nome + ":"));
                    if (index >= 0)
                    {
                        string saldoStr = saldos[index].Split(':')[1];
                        if (decimal.TryParse(saldoStr, out decimal saldoAtual))
                        {
                            if (saldoAtual >= valor)
                            {
                                decimal novoSaldo = saldoAtual - valor;
                                saldos[index] = $"{nome}:{novoSaldo}";
                                File.WriteAllLines(CaminhoSaldos, saldos);
                                Console.WriteLine($"Saque de {valor} realizado com sucesso! Novo saldo: {novoSaldo}");
                            }
                            else
                            {
                                Console.WriteLine("Saldo insuficiente. Operação cancelada.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Erro ao ler o saldo atual. Operação cancelada.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Saldo não encontrado para esta conta. Operação cancelada.");
                    }
                }
                else
                {
                    Console.WriteLine("Valor inválido. Operação cancelada.");
                }
            }
            else
            {
                Console.WriteLine("Nome ou senha incorretos. Tente novamente.");
            }
        }

            // nem sei se precisa dos comentarios, mas vou colocar mesmo assim.
            // isso aqui é o metodo de deposito, ele vai pedir o nome da conta e a senha, depois ele vai verificar se a conta existe, se existir ele vai pedir o valor a ser depositado, depois ele vai atualizar o saldo da conta e mostrar o novo saldo para o cliente.
        public static void Depositar()
        {
            Console.Write("Digite o nome da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a senha da conta: ");
            string senha = Console.ReadLine();
            string conta = $"{nome}:{senha}";
            string[] contas = File.ReadAllLines(CaminhoContas);
            if (contas.Contains(conta))
            {
                Console.Write("Digite o valor a ser depositado: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal valor))
                {
                    string[] saldos = File.ReadAllLines(CaminhoSaldos);
                    int index = Array.FindIndex(saldos, s => s.StartsWith(nome + ":"));
                    if (index >= 0)
                    {
                        string saldoStr = saldos[index].Split(':')[1];
                        if (decimal.TryParse(saldoStr, out decimal saldoAtual))
                        {
                            decimal novoSaldo = saldoAtual + valor;
                            saldos[index] = $"{nome}:{novoSaldo}";
                            File.WriteAllLines(CaminhoSaldos, saldos);
                            Console.WriteLine($"Depósito de {valor} realizado com sucesso! Novo saldo: {novoSaldo}");
                        }
                        else
                        {
                            Console.WriteLine("Erro ao ler o saldo atual. Operação cancelada.");
                        }
                    }
                    else
                    {
                        File.AppendAllText(CaminhoSaldos, $"{nome}:{valor}" + Environment.NewLine);
                        Console.WriteLine($"Depósito de {valor} realizado com sucesso! Novo saldo: {valor}");
                    }
                }
                else
                {
                    Console.WriteLine("Valor inválido. Operação cancelada.");
                }
            }
            else
            {
                Console.WriteLine("Nome ou senha incorretos. Tente novamente.");
            }
        }



        public static void VerificarSaldo()
        {
            Console.Write("Digite o nome da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a senha da conta: ");
            string senha = Console.ReadLine();
            string conta = $"{nome}:{senha}";
            string[] contas = File.ReadAllLines(CaminhoContas);
            if (contas.Contains(conta))
            {
                string[] saldos = File.ReadAllLines(CaminhoSaldos);
                string saldoLinha = saldos.FirstOrDefault(s => s.StartsWith(nome + ":"));
                if (saldoLinha != null)
                {
                    string saldoStr = saldoLinha.Split(':')[1];
                    Console.WriteLine($"O saldo da conta {nome} é: {saldoStr}");
                }
                else
                {
                    Console.WriteLine("Saldo não encontrado para esta conta.");
                }
            }
            else
            {
                Console.WriteLine("Nome ou senha incorretos. Tente novamente.");
            }
        }





            // verificar se o nome da conta já existe antes de criar uma nova conta.
            // se o nome da conta já existir, exibir uma mensagem de erro e solicitar um nome diferente.
            // meu deus isso n acaba depois fazer isso porque eu sou de deus.
        public static void CriarConta()
        {
            Console.Write("Crie o nome da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Crie a senha da conta: ");
            string senha = Console.ReadLine();
            string conta = $"{nome}:{senha}";
            File.AppendAllText(CaminhoContas, conta + Environment.NewLine);
            Console.WriteLine("Conta criada com sucesso!");
            decimal valor = 0;
             string saldo = $"{nome}:{valor}";
            File.AppendAllText(CaminhoSaldos, saldo + Environment.NewLine);
            Console.WriteLine($"Saldo inicial de {valor} registrado com sucesso!");
        }

          public static void CriarConta(string duvida)
        {
            Console.WriteLine($"Saudações, a sua primeira conta no BankGui Banco! {duvida} ");
        }

        // ver as horas para o cliente saber a hora que ele fez a operação.
        // to cansado disso.
        public static string VerHioras() {
            return DateTime.Now.ToString("HH:mm:ss");
        }
        // Depois dessa aqui eu vou dormir, to cansado disso.
        // tem aula hoje...............
        public static void EntrarNaConta()
        {
            Console.Write("Digite o nome da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a senha da conta: ");
            string senha = Console.ReadLine();
            string conta = $"{nome}:{senha}";
            string[] contas = File.ReadAllLines(CaminhoContas);
            if (contas.Contains(conta))
            {
                Console.WriteLine("Login bem-sucedido!");

            }
            else
            {
                Console.WriteLine("Nome ou senha incorretos. Tente novamente.");

            }
        }
    }
}