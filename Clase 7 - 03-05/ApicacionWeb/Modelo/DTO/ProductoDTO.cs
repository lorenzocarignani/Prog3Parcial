using System;
using System.Collections.Generic;
using System.Text;

namespace Modelo.DTO
{
    //CAPA DE MODELO DONDE VOY A TENER ENTIDADES SIN LOGICA
    public class ProductoDTO
    {
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public double PrecioUnitario { get; set; }
        public int Stock { get; set; }
    }
}
