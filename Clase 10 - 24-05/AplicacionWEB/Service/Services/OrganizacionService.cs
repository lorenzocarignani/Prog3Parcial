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

        //Completar como el ejemplo de arriba con los endpoints en su respectivo controlador y los insert en cada una de las tablas que faltan
        public void InsertEmpleado()
        {
        }

        public void InsertEmpresa()
        {
        }
    }
}
