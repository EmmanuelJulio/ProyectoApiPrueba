using Datos;
using Datos.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;



namespace PruebaWebApi.Controllers
{
    public class ProductoController : ApiController
    {

        public IEnumerable<Producto> Get()
        {
            using (var contexto = new ModelContext())
            {
                var productos = (from x in contexto.productos select x);
                return productos;
            }
        }






    }
}
