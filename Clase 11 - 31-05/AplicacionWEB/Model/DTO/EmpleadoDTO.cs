using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTO
{
    public class EmpleadoOrganizacionDTO
    {
        public string NombreEmpleado { get; set; } = string.Empty;
        public string CargoEmpleado { get; set; } = string.Empty;
        public decimal? SalarioEmpleado { get; set; }
        public string RazonSocialEmpresa { get; set; } = string.Empty;
    }

    public class EmpleadoDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
    }
}
