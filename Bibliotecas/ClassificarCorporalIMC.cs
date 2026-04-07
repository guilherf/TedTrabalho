namespace LibrariaIMC
{
    public class ClassificarCorporalIMC
    {
        public static void ClassificarIMC()
        {
            Console.Write("Digite seu peso em kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite sua altura em metros: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);
            Console.WriteLine($"Seu IMC é: {imc:F2}");

            if (imc < 18.5)
            {
                Console.WriteLine("Classificação: Abaixo do peso");
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                Console.WriteLine("Classificação: Peso normal");
            }
            else if (imc >= 25 && imc < 29.99)
            {
                Console.WriteLine("Classificação: Sobrepeso");
            }
            else
            {
                Console.WriteLine("Classificação: Obesidade");
            }
            Console.WriteLine("Pressione Enter para voltar ao menu.");
            Console.ReadLine();
        }
    }
}