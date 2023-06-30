using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.DTO;
using Service;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly ProdcutoService _productoService = new ProdcutoService();

        public ProductoController()
        {

        }


        //POR EJEMPLO ESTE "https://localhost:44334/api/Producto/GetListadoProductos"
        [HttpGet("GetListadoProductos")]
        public ActionResult<List<ProductoDTO>> GetListadoProductos()
        {
            var response = _productoService.GetListadoProductos();

            return Ok(response);
        }

        //POR EJEMPLO ESTE "https://localhost:44334/api/Producto/GetProductoById/2"
        [HttpGet("GetProductoById/{id}")]
        public ActionResult<ProductoDTO> GetProductoById(int id)
        {
            var response = _productoService.GetProductoById(id);

            return Ok(response);
        }

        [HttpPost("PostProducto")]
        public ActionResult<ProductoDTO> CreateProducto([FromBody] ProductoDTO producto)
        {
            var response = _productoService.CreateProducto(producto);

            return Ok(response);
        }

        [HttpPut("PutProducto/{id}")]
        public ActionResult<ProductoDTO> ModifyProducto(int id, [FromBody] ProductoDTO producto)
        {
            var response = _productoService.ModifyProducto(id, producto);

            return Ok(response);
        }

        [HttpDelete("DeleteProducto/{id}")]
        public ActionResult<ProductoDTO> DeleteProducto(int id)
        {
            var response = _productoService.RemoveProducto(id);

            return Ok(response);
        }

    }
}
