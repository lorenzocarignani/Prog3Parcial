using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTO
{
    public class ProductoDTO
    {
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public double PrecioUnitario { get; set; }
        public int Stock { get; set; }
    }
}
