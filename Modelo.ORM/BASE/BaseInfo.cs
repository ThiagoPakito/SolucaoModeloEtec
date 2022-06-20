using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.ORM.BASE
{
    public class BaseInfo
    {
        public Guid Id { get; set; }
        public bool IsNew { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsUpdated { get; set; }

    }
}
