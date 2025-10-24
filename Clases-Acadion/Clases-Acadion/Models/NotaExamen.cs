using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Acadion.Models
{
    public class NotaExamen
    {
        public int IdNota { get; set; }
        public Examen Examen { get; set; }
        public Usuario Estudiante { get; set; }
        public short Calificacion { get; set; }
    }
}
