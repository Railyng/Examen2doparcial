using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Examen2doparcial
{
    public class MaterialBibliografico : Biblioteca
    {
        private string titulo;
        private string autor;


        public MaterialBibliografico(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
        }
        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Título: {titulo}");
            Console.WriteLine($"Autor: {autor}");
        }
    }
   
}
