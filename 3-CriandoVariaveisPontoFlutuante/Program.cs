using System;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 3 - Criando Variaveis Ponto Flutuante");

            double salario;
            salario = 1200.70;

            Console.WriteLine(salario);

            double idade;
            idade = 35 / 2;

            Console.WriteLine("35 / 2 = " + idade);

            idade = 35.0 / 2;
            Console.WriteLine("35.0 / 2 = " + idade);

            double meusalario;
            meusalario = 1846.50;

            Console.WriteLine("Meu salário é " + meusalario);
           


            Console.WriteLine("A Execução acabou. Tecle enter para sair...");
                Console.ReadLine();
        }
    }
}
