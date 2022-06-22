using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Modelo.ORM.INFO;
using Modelo.ORM.DAL;

namespace Modelo.ORM.Bll
{ 


    public class CategoriaBll
    {
        CategoriaDal dal = new CategoriaDal();

        public CategoriaInfo Salvar(CategoriaInfo obj)
        {
            return dal.Salvar(obj);
        }

        public CategoriaInfo Selecionar(int categoriaid)
        {
            return dal.Selecionar(categoriaid);
        }

        public bool Excluir(int categoriaid)
        {
            return dal.Excluir(categoriaid);
        }

        public List<CategoriaInfo> SelecionarTodos()
        {
            return dal.SelecionarTodos();
        }
    }
}
