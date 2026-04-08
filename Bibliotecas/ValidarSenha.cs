namespace SenhaValida
{
    public class ValidarSenha
    {
        public static void VerificarSenha()
        {
            Console.Clear();
            Console.WriteLine("Validador de senhas");
            String senha = "Csharp123";
            Console.Write("Digite a senha: ");
            string senhaDigitada = Console.ReadLine();
            do {
                if (senhaDigitada == senha)
                {
                    Console.WriteLine("Senha correta! Acesso permitido.");
                    break;
                }
                else
                {
                    Console.WriteLine("Senha incorreta. Tente novamente.");
                    Console.Write("Digite a senha: ");
                    senhaDigitada = Console.ReadLine();
                } 

            
        } while (senhaDigitada != senha);
         Console.WriteLine("Pressione Enter para voltar ao menu.");
        Console.ReadLine();
    }
}
}