using System;
using System.Collections.Generic;
using System.Text;
using Datos.Clases;
using System.Linq;
using System.Linq.Expressions;

namespace Datos
{
   public class Crud
    {
        public IEnumerable<Producto> GetProducto()
        {
            using (var db = new ModelContext())
            {
                IEnumerable<Producto> listprod = (from x in db.productos select x);
                return listprod;
            }
        }
    }
}
