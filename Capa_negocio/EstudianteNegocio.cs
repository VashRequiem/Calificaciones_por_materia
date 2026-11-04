using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaNegocio
{
    public class EstudianteNegocio
    {
        //Para poder guardar los nombres de los estudiantes en C# tome la via mas entendible
        //para mi, creo el datatable y listo un diccionario con 5 nombres, los cuales
        //se asocian en el mismo orden con las 5 idEstudiante que cree anteriormente en SQL
        public static DataTable Listar() 
        {
            var nombres = new Dictionary<int, string> // creo el diccionario, el cual espera int para el id y string para el nombre
           {
               {1,"Freddo Goddofredo" },
               {2, "Wildomero Bardo" },
               {3, "Juan Elias" },
               {4, "Josue Martin" },
               {5, "Jorge Coladero" }
           };

            DataTable tabla = EstudianteDatos.ListarEstudiante();
            tabla.Columns.Add("nombreEstudiante", typeof(string)); //agregamos los nombre como string

            foreach (DataRow fila in tabla.Rows) // Establecemos el foreach para que cada final pueda ir asociando los nombres de
                                                 // los estudiantes con sus Ids
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
