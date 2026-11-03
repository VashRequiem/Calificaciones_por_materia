using CapaDatos;
using System.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapaNegocio
{
    public class CalificacionNegocio
    {
        public static DataTable Listar() 
        {
            return CalificacionDatos.ListarCalificacion();
        }
    }
}
