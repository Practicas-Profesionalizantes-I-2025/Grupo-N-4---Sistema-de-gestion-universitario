using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Acadion.Models
{
    public class Examen
    {
        public int Id { get; set; }
        public Materia Materia { get; set; }
        public DateTime Fecha { get; set; }
        public Usuario Docente { get; set; }
        public string TipoExamen { get; set; } // parcial, final, recuperatorio

    }
}
