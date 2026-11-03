using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaNegocio
{
    public class EstudianteNegocio
    {
        public static DataTable Listar() 
        {
            var nombres = new Dictionary<int, string>
           {
               {1,"Freddo Goddofredo" },
               {2, "Wildomero Bardo" },
               {3, "Juan Elias" },
               {4, "Josue Martin" },
               {5, "Jorge Coladero" }
           };

            DataTable tabla = EstudianteDatos.ListarEstudiante();
            tabla.Columns.Add("nombreEstudiante", typeof(string));

            foreach (DataRow fila in tabla.Rows)
            {
                int id = Convert.ToInt32(fila["idEstudiante"]);

                if (nombres.ContainsKey(id))
                {
                    fila["nombreEstudiante"] = nombres[id];
                }
                else
                {
                    fila["nombreEstudiante"] = "Estudiante " + id;
                }
            }
            return tabla;
        }
    }
}
