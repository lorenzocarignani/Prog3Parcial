using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.DTO;
using Model.ViewModel;
using Service.IServices;
using Service.Services;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizacionController : ControllerBase
    {
        private readonly IOrganizacionService _service;

        public OrganizacionController(IOrganizacionService service)
        {
            _service = service;
        }

        [HttpGet("GetListado")]
        public ActionResult<List<EmpleadoDTO>> GetListado()
        {
            var response = _service.GetListadoEmpleados();
            return Ok(response);
        }

        [HttpGet("GetListadoEmpleadoOrganizacion")]
        public ActionResult<List<EmpleadoOrganizacionDTO>> GetListadoEmpleadoOrganizacion()
        {
            var response = _service.GetListadoEmpleadoOrganizacion();
            return Ok(response);
        }

        [HttpPost("InsertCargo")]
        public ActionResult InserCargo([FromBody] CargoViewModel cargo)
        {
            _service.InsertCargo(cargo);
            return Ok();
        }

        [HttpPost("InsertEmpresa")]
        public ActionResult InsertEmpresa([FromBody] EmpresaViewModel empresa)
        {
            _service.InsertEmpresa(empresa);
            return Ok();
        }

        [HttpPost("InsertEmpleado")]
        public ActionResult<string> InsertEmpleado([FromBody] EmpleadoViewModel empleado)
        {
            var response = _service.InsertEmpleado(empleado);
            return Ok(response);
        }
    }
}
