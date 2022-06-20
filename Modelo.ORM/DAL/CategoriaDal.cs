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
    public class CategoriaDal
    {
        public IDbConnection conexao { get; set; }

        public CategoriaDal()
        {
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["strConexao"].ConnectionString);
        }

        const string sqlInserir = @"insert into CATEGORIA (Descricao, IsAtivo) values (@Descicao,@IsAtivo);
                                               select * from CATEGORIA where CategoriaId = scope_identity()";
        const string sqlAtualizar = @"update CATEGORIA set Descricao = @Descricao,
                                                IsAtivo=@IsAtivo where @CategoriaId=@CategoriaID";
        const string sqlExcluir = @"Delete from CATEGORIA where categoriaId=@CategoriaID";
        const string sqlSelecionar = @"Select * from CATEGORIA where categoriaId=@CategoriaId";
        const string sqlSelecionarTodos = @"Select * from CATEGORIA order by Descricao";

        public CategoriaInfo Salvar(CategoriaInfo categoriainfo)
        {
            if (categoriainfo.CategoriaId == 0)
            {
                return conexao.Query<CategoriaInfo>(sqlInserir, categoriainfo).SingleOrDefault();
            }
            else
            {
                conexao.Query<CategoriaInfo>(sqlAtualizar, categoriainfo);
                return categoriainfo;
            }
        }

        public bool Excluir(int categoriaId)
        {
            return conexao.Execute(sqlExcluir, new { CategoriaId = categoriaId }) > 0;

        }
        public CategoriaInfo Selecionar(int categoriaId)
        {
            return conexao.Query<CategoriaInfo>(sqlSelecionar, new { CategoriaID = categoriaId }).SingleOrDefault();
        }
        public List<CategoriaInfo> SelecionarTodos()
        {
            return conexao.Query<CategoriaInfo>(sqlSelecionarTodos, null).ToList();
        }
    }

}
