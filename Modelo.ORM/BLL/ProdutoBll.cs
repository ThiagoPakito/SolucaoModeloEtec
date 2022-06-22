using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Modelo.ORM.INFO;
using Modelo.ORM.DAL;

namespace Modelo.ORM.BLL
{

    public class ProdutoBll
    {
        ProdutoDal dal = new ProdutoDal();

        public ProdutoInfo Salvar (ProdutoInfo obj)
        {
            return dal.Salvar(obj);
        }

        public ProdutoInfo Selecionar (int produtoid)
        {
            return dal.Selecionar(produtoid);
        }

        public bool Excluir (int categoriaid)
        {
            return dal.Excluir(categoriaid);
        }

        public List<ProdutoInfo> SelecionarTodos()
        {
            return dal.SelecionarTodos();
        }
    }
}
