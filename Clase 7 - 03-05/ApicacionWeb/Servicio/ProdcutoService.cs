using Modelo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Servicio
{
    //CAPA DE LOGICA DE NEGOCIOS
    public class ProdcutoService
    {
        public List<ProductoDTO> GetListadoProductos()
        {
            var listadoProductos = new List<ProductoDTO>();

            for (int i = 0; i < 4; i++)
            {
                listadoProductos.Add(new ProductoDTO()
                {
                    IdProducto = i,
                    Descripcion = "Computadora",
                    PrecioUnitario = 250000,
                    Stock = 5
                });
            }

            return listadoProductos;
        }

        public ProductoDTO GetProductoById(int id)
        {
            var listadoProductos = new List<ProductoDTO>();

            for (int i = 0; i < 4; i++)
            {
                listadoProductos.Add(new ProductoDTO()
                {
                    IdProducto = i,
                    Descripcion = "Computadora",
                    PrecioUnitario = 250000,
                    Stock = 5
                });
            }

            ProductoDTO producto  = listadoProductos.Where(x => x.IdProducto == id).First();

            return producto;
        }

        public ProductoDTO CreateProducto(ProductoDTO producto)
        {
            var listadoProductos = new List<ProductoDTO>();

            for (int i = 0; i < 4; i++)
            {
                listadoProductos.Add(new ProductoDTO()
                {
                    IdProducto = i,
                    Descripcion = "Computadora",
                    PrecioUnitario = 250000,
                    Stock = 5
                });
            }

            listadoProductos.Add(producto);

            return producto;
        }

        public List<ProductoDTO> ModifyProducto(int id, ProductoDTO producto)
        {
            var listadoProductos = new List<ProductoDTO>();

            for (int i = 0; i < 4; i++)
            {
                listadoProductos.Add(new ProductoDTO()
                {
                    IdProducto = i,
                    Descripcion = "Computadora",
                    PrecioUnitario = 250000,
                    Stock = 5
                });
            }

            var productoAModificar = listadoProductos.Where(x => x.IdProducto == id).First();
            productoAModificar.IdProducto = producto.IdProducto;
            productoAModificar.Descripcion = producto.Descripcion;
            productoAModificar.PrecioUnitario = producto.PrecioUnitario;
            productoAModificar.Stock = producto.Stock;

            return listadoProductos;
        }

        public List<ProductoDTO> RemoveProducto(int id)
        {
            var listadoProductos = new List<ProductoDTO>();

            for (int i = 0; i < 4; i++)
            {
                listadoProductos.Add(new ProductoDTO()
                {
                    IdProducto = i,
                    Descripcion = "Computadora",
                    PrecioUnitario = 250000,
                    Stock = 5
                });
            }

            var productoAEliminar = listadoProductos.Where(x => x.IdProducto == id).First();
            listadoProductos.Remove(productoAEliminar);

            return listadoProductos;
        }
    }
}
