using System;
using System.Collections.Generic;
using System.Linq;

namespace EjerciciosLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var personas = new List<Persona>();
            personas.Add(new Persona() { Nombre = "Martin", Edad = 22 });
            personas.Add(new Persona() { Nombre = "Juan", Edad = 15 });
            personas.Add(new Persona() { Nombre = "Lucas", Edad = 26 });
            personas.Add(new Persona() { Nombre = "Agustin", Edad = 12 });
            personas.Add(new Persona() { Nombre = "Lucas", Edad = 55 });


            var listPersonas = (from p in personas where p.Edad > 18 orderby p.Edad descending select p).ToList();
            foreach (Persona item in listPersonas)
            {
                Console.WriteLine($"{item.Nombre} tiene {item.Edad}");
            }

            List<string> listNombres = personas.Where(w => w.Edad > 18).Select(s => s.Nombre).OrderByDescending(o => o).ToList();
            foreach (string nom in listNombres)
            {
                Console.WriteLine(nom);
            }


            List<int> nums = new List<int>() { 1, 3, 6, 7, 13, 15, 22 };

            nums = nums.Where(w => w % 2 != 0).ToList();

            var numsFiltrados = nums.Where(w => w > 10 && w < 20).ToList();

            var edadMaxima = personas.Max(w => w.Edad);
            Console.WriteLine(edadMaxima);

            var edadMinima = personas.Min(w => w.Edad);
            Console.WriteLine(edadMinima);

            double promedioNumeros = nums.Average();

            foreach (int num in numsFiltrados)
            {
                Console.WriteLine($"numeros impares {num}, con promedio {promedioNumeros}");
            }

            decimal sumaEdadesPersonas = personas.Sum(s => s.Edad);
            Console.WriteLine(sumaEdadesPersonas);

            string nombre = Console.ReadLine();
            List<Persona> listaConCadenaFiltrada = personas.Where(w => w.Nombre == nombre).ToList();
            foreach (Persona persona in listaConCadenaFiltrada)
            {
                Console.WriteLine(persona.Nombre);
            }


        }
    }

    public class Persona
    {
        public int Edad { get; set; }
        public string Nombre { get; set; }
    }
}
