using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2doparcial
{
    public class Revista : MaterialBibliografico
    {
        private int numeroDeEdicion;

        public Revista(string titulo, string autor, int numeroDeEdicion) : base(titulo, autor)
        {
            this.numeroDeEdicion = numeroDeEdicion;
        }
    }
}
