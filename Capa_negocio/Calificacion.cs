using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
    public class Calificacion //Calificacion es la clase / molde. Define qué datos tiene una calificación, pero no contiene ninguna nota real.
    {
        public int IdCalificaciones { get; set; } //Esta es la estructura de las propiedades de la clase, getter y setter.
        public int IdEstudiante { get; set; }
        public int IdMateria { get; set; }
        public decimal Nota { get; set; }
    }
}
