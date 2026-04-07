namespace TabuadaPersonalizada
{
    public class Tabuada
    {
        public static void GerarTabuada()
        {
            Console.Write("Digite o número para gerar a tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tabuada do {numero}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
             Console.WriteLine("Pressione Enter para voltar ao menu.");
        Console.ReadLine();
        }

    }
}