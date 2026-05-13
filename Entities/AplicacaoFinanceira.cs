using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1AplicacaoFinanceira.Entities
{
    public class AplicacaoFinanceira
    {

        public int Id { get; set; }
        public string? Nome { get; set; }
        public double Valor { get; set; }
        public bool IsFinalizado { get; set; }
        public AplicacaoFinanceira()
        { 
        }
        public AplicacaoFinanceira(string? nome, double valor, bool isFinalizado)
        {
            Nome = nome;
            Valor = valor;
            IsFinalizado = isFinalizado;
        }

        public override string? ToString()
        {
            return $"{Id} / {Nome} / {Valor} / {IsFinalizado}";
        }
    }

}
