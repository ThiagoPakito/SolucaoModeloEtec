using Modelo.ORM.BASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.ORM.INFO
{
    public class CategoriaInfo: BaseInfo
    {
        public int CategoriaId { get; set; }
        public string Descricao { get; set; }
        public bool IsAtivo { get; set; }
        
    }
}
