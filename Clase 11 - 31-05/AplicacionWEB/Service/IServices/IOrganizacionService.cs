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
        List<EmpleadoOrganizacionDTO> GetListadoEmpleadoOrganizacion();
        void InsertCargo(CargoViewModel cargo);
        void InsertEmpresa(EmpresaViewModel empresa);
        string InsertEmpleado(EmpleadoViewModel empleado);
    }
}
