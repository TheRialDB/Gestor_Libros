using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Backend
{
    public class Libro
    {
        //atributos
        private string codigo;
        private string titulo;
        private string autor;
        private string editorial;
        private string genero;

        //constructor vacio
        public Libro()
        {

        }
        //constructor con parametros
        public Libro(string codigo, string titulo, string autor, string editorial, string genero)
        {
            this.codigo = codigo;
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
            this.genero = genero;
        }

        //gets sets
        public string Codigo { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Editorial { get; set; }

        public string Genero { get; set; }  
    }
}
