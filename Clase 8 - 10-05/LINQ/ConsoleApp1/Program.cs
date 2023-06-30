using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Empleado> empleados = new List<Empleado>();
            empleados.Add(new Empleado() { Id = 1, Nombre = "Agustin", FechaNacimiento = new DateTime(1997, 11, 11), Cargo = "Desarrolador", Salario = 250000, Edad = 25 });
            empleados.Add(new Empleado() { Id = 2, Nombre = "Lucas", FechaNacimiento = new DateTime(1994, 11, 23), Cargo = "Desarrolador",  Salario = 300000, Edad = 20 });
            empleados.Add(new Empleado() { Id = 2, Nombre = "Guido", FechaNacimiento = new DateTime(1994, 11, 23), Cargo = "Desarrolador", Salario = 320000, Edad = 20 });
            empleados.Add(new Empleado() { Id = 3, Nombre = "Esteban", FechaNacimiento = new DateTime(2005, 05, 15), Cargo = "RR.HH",  Salario = 550000, Edad = 30 });
            empleados.Add(new Empleado() { Id = 3, Nombre = "Silvia", FechaNacimiento = new DateTime(2005, 05, 15), Cargo = "RR.HH", Salario = 560000, Edad = 38 });
            empleados.Add(new Empleado() { Id = 4, Nombre = "Diego", FechaNacimiento = new DateTime(2010, 05, 15), Cargo = "Administrativo", Salario = 325000, Edad = 35 });
            empleados.Add(new Empleado() { Id = 5, Nombre = "Claudia", FechaNacimiento = new DateTime(2010, 05, 15), Cargo = "RR.HH", Salario = 200000, Edad = 18 });

            var list2 = empleados
                .Where(w => w.Salario >= 300000)
                .OrderByDescending(o => o.Salario)
                .ThenBy(t => t.Edad)
                .Skip(3)
                .ToList();

            foreach (var item in list2)
            {
                string descripcion = $"El empleado {item.Nombre} {item.Cargo} gana {item.Salario}";
                Console.WriteLine(descripcion);
            }

            //var list3 = new List<Empleado>();
            //foreach (var item in empleados)
            //{
            //    item.Cargo = "que su cargo es:" + item.Cargo;
            //    if (item.Salario >= 300000)
            //    {
            //        list3.Add(item);
            //    }
            //}

            //foreach (var item in list2)
            //{
            //    string descripcion = $"El empleado {item.Nombre} {item.Cargo} gana {item.Salario}";
            //    Console.WriteLine(descripcion);
            //}
        }
    }

    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }
        public int Edad { get; set; }
    }
}
