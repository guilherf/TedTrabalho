namespace TemperaturasConverter
{
    public class ConversorTemperaturasUniversais
    {
        public static void ConverterTemperaturas()
        {
            Console.WriteLine("Bem-vindo ao Conversor de Temperaturas");
            bool mostrarConsole = true;
            do
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1. Celsius para Fahrenheit");
                Console.WriteLine("2. Fahrenheit para Celsius");
                Console.WriteLine("3. Celsius para Kelvin");
                Console.WriteLine("4. Kelvin para Celsius");
                Console.WriteLine("5. Fahrenheit para Kelvin");
                Console.WriteLine("6. Kelvin para Fahrenheit");
                Console.WriteLine("0. Voltar ao menu principal");

                Console.Write("Digite sua opção: ");
                int opcao = int.TryParse(Console.ReadLine(), out opcao) ? opcao : -1;
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Você escolheu Celsius para Fahrenheit.");
                        Console.Write("Digite a temperatura em Celsius: ");
                        double celsius = double.TryParse(Console.ReadLine(), out celsius) ? celsius : 0;
                        double fahrenheit = (celsius * 9 / 5) + 32;
                        Console.WriteLine($"Resultado: {celsius} °C = {fahrenheit} °F");
                        break;
                    case 2:
                        Console.WriteLine("Você escolheu Fahrenheit para Celsius.");
                        Console.Write("Digite a temperatura em Fahrenheit: ");
                        double fahrenheit2 = double.TryParse(Console.ReadLine(), out fahrenheit2) ? fahrenheit2 : 0;
                        double celsius2 = (fahrenheit2 - 32) * 5 / 9;
                        Console.WriteLine($"Resultado: {fahrenheit2} °F = {celsius2} °C");
                        break;
                    case 3:
                        Console.WriteLine("Você escolheu Celsius para Kelvin.");
                        Console.Write("Digite a temperatura em Celsius: ");
                        double celsius3 = double.TryParse(Console.ReadLine(), out celsius3) ? celsius3 : 0;
                        double kelvin = celsius3 + 273.15;
                        Console.WriteLine($"Resultado: {celsius3} °C = {kelvin} K");
                        break;
                    case 4:
                        Console.WriteLine("Você escolheu Kelvin para Celsius.");
                        Console.Write("Digite a temperatura em Kelvin: ");
                        double kelvin2 = double.TryParse(Console.ReadLine(), out kelvin2) ? kelvin2 : 0;
                        double celsius4 = kelvin2 - 273.15;
                        Console.WriteLine($"Resultado: {kelvin2} K = {celsius4} °C");
                        break;
                }
            } while (mostrarConsole);
            Console.WriteLine("Pressione Enter para voltar ao menu.");
            Console.ReadLine();
        }
    }
}