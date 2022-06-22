using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using Modelo.ORM.INFO;

namespace Modelo.ORM.DAL
{
    public class ProdutoDal

    {
        public IDbConnection conexao { get; set; }
        public ProdutoDal()
        {
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["strConexao"].ConnectionString);
        }
        const string sqlInserir = @"insert into PRODUTOS (CategoriaId,Descricao,DescricaoReduziada,Unidade,ValorCusto,PorcentagemLucro,ValorVenda1,ValorVenda2,ValorVenda3,ValorVenda4,ValorVenda,IsPromocao,IsForaDeLinha,IsPesavel,Marca,Modelo,Referencia,CodigoBarra,IsPermiteDesconto,DescontoMaximo,EstoqueAtual,EstoqueMaximo,EstoqueMinimo,BalancaSetor,BalancaDiasValidade,BalancaReceita,IsAtivo,Foto)
            values(@CategoriaId,@Descricao,@DescricaoReduziada,@Unidade,@ValorCusto,@PorcentagemLucro,@ValorVenda1,@ValorVenda2,@ValorVenda3,@ValorVenda4,@ValorVenda,@IsPromocao,@IsForaDeLinha,@IsPesavel,@Marca,@Modelo,@Referencia,@CodigoBarra,@IsPermiteDesconto,@DescontoMaximo,@EstoqueAtual,@EstoqueMaximo,@EstoqueMinimo,@BalancaSetor,@BalancaDiasValidade,@BalancaReceita,@IsAtivo,@Foto)
            select * from Produtos where CategoriaId=scope_identity()";
        const string sqlAtualizar = @"update PRODUTOS set CategoriaId=@CategoriaId,	Descricao=@Descricao,	DescricaoReduziada=@DescricaoReduziada,	Unidade=@Unidade,	ValorCusto=@ValorCusto,	PorcentagemLucro=@PorcentagemLucro,	ValorVenda1=@ValorVenda1,	ValorVenda2=@ValorVenda2,	ValorVenda3=@ValorVenda3,	ValorVenda4=@ValorVenda4,
                                    ValorVenda=@ValorVenda,	IsPromocao=@IsPromocao,	IsForaDeLinha=@IsForaDeLinha,	IsPesavel=@IsPesavel,	Marca=@Marca,	Modelo=@Modelo,	Referencia=@Referencia,	CodigoBarra=@CodigoBarra,	IsPermiteDesconto=@IsPermiteDesconto,	DescontoMaximo=@DescontoMaximo,	EstoqueAtual=@EstoqueAtual,
                                    EstoqueMaximo=@EstoqueMaximo,	EstoqueMinimo=@EstoqueMinimo,	BalancaSetor=@BalancaSetor,	BalancaDiasValidade=@BalancaDiasValidade,	BalancaReceita=@BalancaReceita,	IsAtivo=@IsAtivo,Foto=@Foto where produtoId=@ProdutoId";
        const string sqlExcluir = @"delete from PRODUTOS where produtpoId=@ProdutoId";
        const string sqlSelecionar = @"select * from Produtos where produtoId=@ProdutoId";
        const string SqlSelecionarTodos = @"select * from Produtos order By Descricao";

        public ProdutoInfo Salvar(ProdutoInfo produtoinfo)
        {
            if (produtoinfo.ProdutoId == 0)
            {
                return conexao.Query<ProdutoInfo>(sqlInserir, produtoinfo).SingleOrDefault();
            }
            else
            {
                conexao.Query<ProdutoInfo>(sqlAtualizar, produtoinfo);
                return produtoinfo;
            }
        }

        public bool Excluir(int produtoId)
        {
            return conexao.Execute(sqlExcluir, new { ProdutoId = produtoId }) > 0;

        }
        public ProdutoInfo Selecionar(int produtoId)
        {
            return conexao.Query<ProdutoInfo>(sqlSelecionar, new { ProdutoID = produtoId }).SingleOrDefault();
        }
        public List<ProdutoInfo> SelecionarTodos()
        {
            return conexao.Query<ProdutoInfo>(SqlSelecionarTodos, null).ToList();
        }
    }
}
