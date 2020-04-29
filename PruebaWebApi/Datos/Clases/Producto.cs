using System;
using System.Collections.Generic;
using System.Text;

namespace Datos.Clases
{
    public  class Producto
    {
        int id;
        string nombre;
        decimal precio;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal Precio { get => precio; set => precio = value; }
    }
}
