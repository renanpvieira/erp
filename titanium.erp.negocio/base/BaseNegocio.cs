using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using titanium.erp.data;


namespace titanium.erp.negocio
{
    public abstract class BaseNegocio {
        public IUnitOfWork UOW { get; set; }
    }

}
