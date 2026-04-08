using System.Linq.Expressions;

namespace MediaAluno
{
    public class CalcularMedia
    {
        public static void CalcularMediaAluno()
        {
            bool continuar = true;
            do
            {
                string nomeAluno;
                do {
                    Console.Clear();
                    Console.WriteLine("Media do Aluno");
                    Console.WriteLine();
                    Console.Write("Digite o nome do aluno: ");
                    nomeAluno = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(nomeAluno))
                    {
                        Console.WriteLine("O nome do aluno não pode ser vazio. Por favor, tente novamente.");
                    }
                } while (string.IsNullOrWhiteSpace(nomeAluno));
                
                double nota1, nota2, nota3;
                while (true)
                {
                    Console.Write("Digite a primeira nota: ");
                    if (double.TryParse(Console.ReadLine(), out nota1) && nota1 >= 0 && nota1 <= 10)
                        break;
                    Console.WriteLine("Nota inválida. Por favor, insira um valor entre 0 e 10.");
                }
                while (true)
                {
                    Console.Write("Digite a segunda nota: ");
                    if (double.TryParse(Console.ReadLine(), out nota2) && nota2 >= 0 && nota2 <= 10)
                        break;
                    Console.WriteLine("Nota inválida. Por favor, insira um valor entre 0 e 10.");
                }
                while (true)
                {
                    Console.Write("Digite a terceira nota: ");
                    if (double.TryParse(Console.ReadLine(), out nota3) && nota3 >= 0 && nota3 <= 10)
                        break;
                    Console.WriteLine("Nota inválida. Por favor, insira um valor entre 0 e 10.");
                }

                double media = (nota1 + nota2 + nota3) / 3;
                Console.WriteLine($"A média do aluno {nomeAluno} é: {media:F2}");

                if (media >= 7)
                {
                    Console.WriteLine("Status: Aprovado");
                }
                else if (media >= 6)
                {
                    Console.WriteLine("Status: Recuperação");
                }
                else
                {
                    Console.WriteLine("Status: Reprovado");
                }   
            } while (!continuar);

            Console.WriteLine("Pressione Enter para voltar ao menu.");
            Console.ReadLine();


        }
    } 
}