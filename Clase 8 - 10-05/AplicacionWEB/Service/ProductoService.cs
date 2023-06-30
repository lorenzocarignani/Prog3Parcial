using Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    //CAPA DE LOGICA DE NEGOCIOS
    public class ProdcutoService
    {
        static List<ProductoDTO> listadoProductos = new List<ProductoDTO>();

        public List<ProductoDTO> GetListadoProductos()
        {
            return listadoProductos;
        }

        public ProductoDTO GetProductoById(int id)
        {
            ProductoDTO producto = listadoProductos.Where(x => x.IdProducto == id).First();

            return producto;
        }

        public ProductoDTO CreateProducto(ProductoDTO producto)
        {
            listadoProductos.Add(producto);

            return producto;
        }

        public List<ProductoDTO> ModifyProducto(int id, ProductoDTO producto)
        {
            var productoAModificar = listadoProductos.Where(x => x.IdProducto == id).First();
            productoAModificar.IdProducto = producto.IdProducto;
            productoAModificar.Descripcion = producto.Descripcion;
            productoAModificar.PrecioUnitario = producto.PrecioUnitario;
            productoAModificar.Stock = producto.Stock;

            return listadoProductos;
        }

        public List<ProductoDTO> RemoveProducto(int id)
        {
            var productoAEliminar = listadoProductos.Where(x => x.IdProducto == id).First();
            listadoProductos.Remove(productoAEliminar);

            return listadoProductos;
        }
    }
}
