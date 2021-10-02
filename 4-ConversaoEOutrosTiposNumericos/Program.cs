using System;

namespace _4_ConversaoEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o PROJETO");

            double salario;
            salario = 2500.86;

            // é um tipo de variável que suporta até 32 bits
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            // long é uma variavel de 64 bits
            long idade = 160000000000000;
            Console.WriteLine(idade);

            // o short é um tipo de variável de 16 bits
            short quantidadeProdutos = 16000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.ReadLine();  
        }
    }
}
