using System;
using System.Collections.Generic;
using System.Linq;

namespace JoinLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpleadoxEmpres oEmpleadoEmpresa = new EmpleadoxEmpres();
            List<EmpleadoDTO> empleaddosFromGoogle = (from empleado in oEmpleadoEmpresa.empleados
                                                      join empresa in oEmpleadoEmpresa.empresas
                                                      on empleado.IdEmpresa equals empresa.Id
                                                      join cargo in oEmpleadoEmpresa.cargos
                                                      on empleado.IdCargo equals cargo.Id
                                                      select new EmpleadoDTO()
                                                      {
                                                          IdEmpleado = empleado.Id,
                                                          NombreEmpleado = empleado.Nombre,
                                                          CargoEmpleado = cargo.Descripcion,
                                                          SalarioEmpleado = cargo.Salario,
                                                          IdEmpresa = empresa.Id,
                                                          RazonSocialEmpresa = empresa.RazonSocial
                                                      }).ToList();

            foreach (EmpleadoDTO item in empleaddosFromGoogle)
            {
                Console.WriteLine($"El empleado {item.IdEmpleado}-{item.NombreEmpleado} trabaja de {item.CargoEmpleado} en la empresa {item.IdEmpresa}-{item.RazonSocialEmpresa} gana {item.SalarioEmpleado}");
            }

        }
    }

    public class EmpleadoDTO
    {
        public int IdEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public string CargoEmpleado { get; set; }
        public double SalarioEmpleado { get; set; }
        public int IdEmpresa { get; set; }
        public string RazonSocialEmpresa { get; set; }
    }

    public class EmpleadoxEmpres
    {
        public List<Empleado> empleados = new List<Empleado>();
        public List<Empresa> empresas = new List<Empresa>();
        public List<Cargo> cargos = new List<Cargo>();

        public EmpleadoxEmpres()
        {
            empleados.Add(new Empleado() { Id = 1, Nombre = "Matias", IdCargo = 1, IdEmpresa = 1 });
            empleados.Add(new Empleado() { Id = 2, Nombre = "Lucas", IdCargo = 1, IdEmpresa = 1 });
            empleados.Add(new Empleado() { Id = 3, Nombre = "Agustina", IdCargo = 2, IdEmpresa = 1 });
            empleados.Add(new Empleado() { Id = 4, Nombre = "Carla", IdCargo = 3, IdEmpresa = 1 });
            empleados.Add(new Empleado() { Id = 5, Nombre = "Santiago", IdCargo = 3, IdEmpresa = 2 });
            empleados.Add(new Empleado() { Id = 6, Nombre = "Esteban", IdCargo = 1, IdEmpresa = 2 });

            empresas.Add(new Empresa() { Id = 1, RazonSocial = "Google" });
            empresas.Add(new Empresa() { Id = 2, RazonSocial = "Facebook" });

            cargos.Add(new Cargo() { Id = 1, Descripcion = "Desarrollador", Salario = 250000 });
            cargos.Add(new Cargo() { Id = 2, Descripcion = "CEO", Salario = 500000 });
            cargos.Add(new Cargo() { Id = 3, Descripcion = "RRHH", Salario = 300000 });
        }
    }

    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int IdCargo { get; set; }
        public int IdEmpresa { get; set; }
    }

    public class Empresa
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
    }

    public class Cargo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Salario { get; set; }
    }
}
