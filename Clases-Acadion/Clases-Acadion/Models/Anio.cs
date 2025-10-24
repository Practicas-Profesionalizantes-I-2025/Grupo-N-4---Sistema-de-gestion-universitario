using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Acadion.Models
{
    public class Anio
    {
        public int IdAnio { get; set; }
        public int NumeroAnio { get; set; }
        public Materia Materia { get; set; }
        public Usuario Docente { get; set; }
        public string Horario { get; set; }
        public List<Usuario> AlumnosInscriptos { get; set; }
        public int AnioLectivo { get; set; }

    }
}
