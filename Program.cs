using ConsoleApp1AplicacaoFinanceira.Entities;

namespace ConsoleApp1AplicacaoFinanceira
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var context = new AplicacaoFinanceiraDbContext();

            Console.WriteLine("== Salvando AplicacaoFinanceira ==");

            AplicacaoFinanceira ap = new ("Poupança",1, false);

            context.AplicacaoFinanceiraS.Add(ap);

            //context.SaveChanges();

            Console.WriteLine("== Recuperando AplicacaoFinanceira ==");

            Console.WriteLine("== SELECT * ==");
            var DadosRecuperados =context.AplicacaoFinanceiraS.ToList();
            DadosRecuperados.ForEach(x => Console.WriteLine(x));

            Console.WriteLine("== SELECT WHERE ==");
            var dadoRecuperado = context.AplicacaoFinanceiraS.Find(3);
            Console.WriteLine(dadoRecuperado);

            context.AplicacaoFinanceiraS.Remove(dadoRecuperado);

            Console.WriteLine("== SELECT * ==");
            var DadosAtualizados = context.AplicacaoFinanceiraS.ToList();
            DadosRecuperados.ForEach(x => Console.WriteLine(x));
        }
    }
}