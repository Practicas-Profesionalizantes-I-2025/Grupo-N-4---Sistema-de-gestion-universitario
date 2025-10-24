using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Acadion.Models
{
    public class Materia
    {
        public int IdMateria { get; set; }
        public string Nombre { get; set; }
        public Usuario Profesor { get; set; }
        public int Anio { get; set; }
        public List<Materia> Correlativas { get; set; }
        public EstadoMateria Estado { get; set; }
        public string Modalidad { get; set; } // presencial, virtual, mixta
    }
}
