using System;

namespace Aplicacao
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exemplo de testes com Nunit:");
            Console.WriteLine("Soma: {0}", Utilitarios.Somar(10, 20));
            Console.WriteLine("Multiplicar: {0}", Utilitarios.Multiplicar(10, 20));
            Console.WriteLine("Subtrair: {0}", Utilitarios.Subtrair(20, 5));
            Console.WriteLine("Dividir: {0}", Utilitarios.Dividir(10, 5));
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}