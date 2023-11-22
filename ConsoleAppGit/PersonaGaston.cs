using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppGit;

namespace ConsoleAppGit
{
    public class PersonaGaston
    {
        public string Nombre { get; set; }

        public string getNombre()
        {
            return Nombre;
        }

        public void program_gs()
        {

            PersonaGaston pg = new PersonaGaston();

            pg.Nombre = "Gastón";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Cambios " + pg.Nombre);


            Console.WriteLine("Hola TimeSolution");

            Console.BackgroundColor = ConsoleColor.Red;
        }

    }
}
