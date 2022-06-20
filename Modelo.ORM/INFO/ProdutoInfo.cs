using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.ORM.BASE;

namespace Modelo.ORM.INFO
{
    public class ProdutoInfo : BaseInfo
    {
        public Int32 ProdutoId { get; set; }
        public Int32 CategoriaId { get; set; }
        public string Descricao { get; set; }
        public string DescricaoReduziada { get; set; }
        public string Unidade { get; set; }
        public decimal ValorCusto { get; set; }
        public decimal PorcentagemLucro { get; set; }
        public decimal ValorVenda1 { get; set; }
        public decimal ValorVenda2 { get; set; }
        public decimal ValorVenda3 { get; set; }
        public decimal ValorVenda4 { get; set; }
        public decimal ValorVenda { get; set; }
        public bool IsPromocao { get; set; }
        public bool IsForaDeLinha { get; set; }
        public bool IsPesavel { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Referencia { get; set; }
        public string CodigoBarra { get; set; }
        public bool IsPermiteDesconto { get; set; }
        public decimal DescontoMaximo { get; set; }
        public decimal EstoqueAtual { get; set; }
        public decimal EstoqueMaximo { get; set; }
        public decimal EstoqueMinimo { get; set; }
        public Int32 BalancaSetor { get; set; }
        public Int32 BalancaDiasValidade { get; set; }
        public string BalancaReceita { get; set; }
        public bool IsAtivo { get; set; }
        public string Foto { get; set; }
    }
}
