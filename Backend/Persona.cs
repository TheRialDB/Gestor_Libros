using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Persona
    {
        //atributos
        private string nombre;
        private string apellido;
        private string dni;

        //constructor vacio
        public Persona()
        {

        }

        //gets sets
        public string Nombre { get; set; }

        public string Apellido { get; set; }
        
        public string Dni { get; set; }
    }
}
