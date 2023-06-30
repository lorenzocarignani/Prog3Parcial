using Model.DTO;
using Model.Models;
using Model.ViewModel;
using Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class OrganizacionService : IOrganizacionService
    {
        // Creamos la variable para luego relizar la inyeccion de dependencia en el constructor
        private readonly OrganizacionContext _context;

        public OrganizacionService(OrganizacionContext _context)
        {
            this._context = _context;
        }

        public List<EmpleadoDTO> GetListadoEmpleados()
        {
            var usuario = _context.Empleado.ToList();
            var usuarioResponse = new List<EmpleadoDTO>();

            foreach (var usu in usuario)
            {
                usuarioResponse.Add(new EmpleadoDTO()
                {
                    Id = usu.Id,
                    Nombre = usu.Nombre
                });
            }

            return usuarioResponse;
        }

        public List<EmpleadoOrganizacionDTO> GetListadoEmpleadoOrganizacion()
        {
            List<EmpleadoOrganizacionDTO> empleados = (from empleado in _context.Empleado
                                                       join empresa in _context.Empresa
                                                       on empleado.IdEmpresa equals empresa.Id
                                                       join cargo in _context.Cargo
                                                       on empleado.IdCargo equals cargo.Id
                                                       select new EmpleadoOrganizacionDTO()
                                                       {
                                                           NombreEmpleado = empleado.Nombre,
                                                           CargoEmpleado = cargo.Descripcion,
                                                           SalarioEmpleado = cargo.Salario,
                                                           RazonSocialEmpresa = empresa.RazonSocial
                                                       }).ToList();

            return empleados;
        }

        public void InsertCargo(CargoViewModel cargo)
        {
            _context.Cargo.Add(new Cargo()
            {
                Descripcion = cargo.Descripcion,
                Salario = cargo.Salario
            });

            _context.SaveChanges();
        }

        public void InsertEmpresa(EmpresaViewModel empresa)
        {
            _context.Empresa.Add(new Empresa()
            {
                RazonSocial = empresa.RazonSocial
            });

            _context.SaveChanges();
        }

        public string InsertEmpleado(EmpleadoViewModel empleado)
        {
            string response = string.Empty;
            // Obtenemos mediante LINQ el primer cargo que coincida con el idCargo que enviamos en el ViewModel, de lo contrario asignamos null
            var cargo = _context.Cargo.FirstOrDefault(f => f.Id == empleado.IdCargo);
            // Obtenemos mediante LINQ la primer empresa que coincida con el idEmpresa que enviamos en el ViewModel, de lo contrario asignamos null
            var empresa = _context.Empresa.FirstOrDefault(f => f.Id == empleado.IdEmpresa);
            // Validamos que cargo y empresa existan y no sean null
            // Esto se realiza debido a que IdCargo y IdEmpresa son CLAVES FORANEAS de la tabla Empleado, por ende NO deben ser null
            if (cargo != null && empresa != null)
            {
                _context.Empleado.Add(new Empleado()
                {
                    Nombre = empleado.Nombre,
                    IdCargo = cargo.Id,
                    IdEmpresa = empresa.Id
                });

                _context.SaveChanges();
                response = "Empleado agregado exitosamente!";
            }
            else
            {
                response = "Hubo un error en la seleccion del cargo y/o la empresa";
            }

            return response;
        }
    }
}
