using Model.DTO;
using Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.IServices
{
    public interface IOrganizacionService
    {
        List<EmpleadoDTO> GetListadoEmpleados();
        void InsertCargo(CargoViewModel cargo);
        List<EmpleadoOrganizacionDTO> GetListadoEmpleadoOrganizacion();
        void InsertEmpleado();
        void InsertEmpresa();
    }
}
