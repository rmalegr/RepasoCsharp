using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Empleado
    {
        public string Nombre { get; set; }
        public string Descripcion  { get; set;}
        public double Sueldo { get; set; }
        public  int Edad { get; set; }

        public Empleado(string nombre, string descripcion, double sueldo, int edad)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Sueldo = sueldo;
            Edad = edad;
        }

        

       




    }
}
