using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Acadion.Models
{
    public class Carrera
    {
        public int IdCarrera { get; set; }
        public string Nombre { get; set; }
        public List<Materia> Materias { get; set; }
        //public PlanEstudios PlanEstudios { get; set; }
    }
}
