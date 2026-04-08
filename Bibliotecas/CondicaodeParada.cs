namespace CondicaodeParada
{
    public class CondicaodeParadaVerificar
    {
        public static void VerificarCondicao()
        {
            

            int numero = 0;
            int soma = 0;
            Console.Clear();
            Console.WriteLine("Condição de parada");

            Console.WriteLine("Digite números para somar. Digite 0 para parar.");
            Console.WriteLine("Digite numeros negativos para parar.");


            while (numero >= 0)
            {
                Console.Write("Digite um número: ");
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    if (numero <= 0)
                    {
                        break;
                    }
                    soma += numero;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                }
            }
            Console.WriteLine($"A soma dos números digitados é: {soma}");
            Console.WriteLine("Pressione Enter para voltar ao menu.");
            Console.ReadLine();
           
           
        }
    }
}