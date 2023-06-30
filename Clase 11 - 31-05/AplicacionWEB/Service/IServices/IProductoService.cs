using Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IServices
{
    public interface IProductoService
    {
        List<ProductoDTO> GetListadoProductos();
        ProductoDTO GetProductoById(int id);
        ProductoDTO CreateProducto(ProductoDTO producto);
        List<ProductoDTO> ModifyProducto(int id, ProductoDTO producto);
        List<ProductoDTO> RemoveProducto(int id);
    }
}
