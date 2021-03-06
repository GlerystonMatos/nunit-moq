using System;
using System.Linq;

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

            CidadeService cidadeService = new CidadeService(new CidadeRepository());
            Console.WriteLine("Exemplo de testes com Nunit e Moq:");
            Console.WriteLine("Create: {0}", cidadeService.Create(new Cidade("Fortaleza")));
            Console.WriteLine("Update: {0}", cidadeService.Update(new Cidade("Fortaleza")));
            Console.WriteLine("Remove: {0}", cidadeService.Remove(new Cidade("Fortaleza")));
            Console.WriteLine("GetAll Count: {0}", cidadeService.GetAll().ToList().Count);
            Console.WriteLine("FindById: {0}", cidadeService.FindById(Guid.NewGuid()).Nome);
        }
    }
}