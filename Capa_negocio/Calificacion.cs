using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
    public class Calificacion
    {
        public int IdCalificaciones { get; set; }
        public int IdEstudiante { get; set; }
        public int IdMateria { get; set; }
        public decimal Nota { get; set; }
    }
}
