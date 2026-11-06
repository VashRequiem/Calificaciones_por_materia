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
        //para mi, en este caso cree el diccionario de los nombres como campo de mi
        //clase EstudianteNegocio, para luego obtener los nombres mediante metodos
        
        private static Dictionary<int, string> nombres = new Dictionary<int, string> // creo el diccionario, el cual espera int para el id y string para el nombre
           {
               {1,"Freddo Goddofredo" },
               {2, "Wildomero Bardo" },
               {3, "Juan Elias" },
               {4, "Josue Martin" },
               {5, "Jorge Coladero" }
           };
        public static string ObtenerNombre(int idEstudiante)
        {
            //El if / else con ContainsKey protege el caso de un id sin nombre
            if (nombres.ContainsKey(idEstudiante))
            {
                return nombres[idEstudiante];
            }
            else
            {
                return "Estudiante " + idEstudiante; //esto viene siendo una defensa a futuro, por si agregamos
                                                     //la opcion de permitir al usuario agregar estudiantes 
            }
        }

        public static DataTable Listar() 
        {
            DataTable tabla = EstudianteDatos.ListarEstudiante();
            tabla.Columns.Add("nombreEstudiante", typeof(string)); //agregamos los nombre como string

            foreach (DataRow fila in tabla.Rows) // Establecemos el foreach para que cada final pueda ir asociando los nombres de
                                                 // los estudiantes con sus Ids
            {
                int id = Convert.ToInt32(fila["idEstudiante"]);

                fila["nombreEstudiante"] = ObtenerNombre(id);
            }
            return tabla;
        }
    }
}
