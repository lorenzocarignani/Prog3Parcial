using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelo.DTO;
using Servicio;
using System.Collections.Generic;

namespace Api.Controllers
{
    ////DECORADOR QUE INDICA LA RUTA DEL CONTROLADOR
    [Route("api/[controller]")]
    //DECORADOR QUE INDICAN QUE ESTA CLASE ES UN CONTROLADOR
    [ApiController]
    public class ProductoController : ControllerBase
    {
        //INYECCION DE DEPENDENCIA DEL SERVICIO
        private readonly ProdcutoService _productoService = new ProdcutoService();

        public ProductoController()
        {
            
        }

        //ENDPOINTS CON SUS RESPECTIVAS RUTAS Y VERBOS HTTP


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
