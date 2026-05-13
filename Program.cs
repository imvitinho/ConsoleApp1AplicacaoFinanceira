using ConsoleApp1AplicacaoFinanceira.Entities;
using var context = new AplicacaoFinanceiraDbContext();

Console.WriteLine("== Salvando AplicacaoFinanceira ==");


// Cria um novo objeto e salva na lista
AplicacaoFinanceira ap = new("CDB", 100, false);
context.AplicacaoFinanceiraS.Add(ap);
Console.WriteLine("== Recuperando AplicacaoFinanceira ==");


// Seleciona todos os dados da lista
Console.WriteLine("== SELECT * ==");
var DadosRecuperados = context.AplicacaoFinanceiraS.ToList();
DadosRecuperados.ForEach(x => Console.WriteLine(x));


// Seleciona um dado específico da lista
Console.WriteLine("== SELECT WHERE ==");
var dadoRecuperado = context.AplicacaoFinanceiraS.Find(4);
Console.WriteLine(dadoRecuperado);


// Remove um dado específico da lista
Console.WriteLine("== REMOVE ==");
if (dadoRecuperado != null)
{
    context.AplicacaoFinanceiraS.Remove(dadoRecuperado);
    context.SaveChanges();
}
else
{
    Console.WriteLine("Nada a remover.");
}