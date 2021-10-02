using System;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 2 - Criando Variaveis");

            int idade;
            idade = 32;

            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);

            idade = 10 + 20 - 5;
            Console.WriteLine(idade);
            Console.WriteLine("Sua idade é " + idade);

            int x, y, z;
                x = 2;
                y = 1;
                z = 3;

            Console.WriteLine(x);

            x = y + z;
            Console.WriteLine(x);


            Console.WriteLine("Execução finalizada. Tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
