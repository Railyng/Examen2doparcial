using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2doparcial
{
    public class Libro : MaterialBibliografico
    {
        private int numeroDePaginas;

        public Libro(string titulo, string autor, int numeroDePaginas) : base(titulo, autor)
        {
            this.numeroDePaginas = numeroDePaginas;
        }
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Número de páginas: {numeroDePaginas}");
        }
    }
}
