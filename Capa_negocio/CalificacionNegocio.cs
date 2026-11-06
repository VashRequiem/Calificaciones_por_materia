
using System;
using System.Collections.Generic;
using System.Text;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class CalificacionNegocio
    {
        public static DataTable Listar() 
        {
            DataTable tabla = CalificacionDatos.ListarCalificacion();  //pido y guardo 
            AgregarNombres(tabla);                                     // Modifico 
            return tabla;                                              // Devuelvo
        }

        public static DataTable ListarPorEstudiante(int idEstudiante)
        {
            DataTable tabla = CalificacionDatos.ListarPorEstudiante(idEstudiante);
            AgregarNombres(tabla);
            return tabla;
        }

        private static void AgregarNombres(DataTable tabla) 
        {
            tabla.Columns.Add("nombreEstudiante", typeof(string)); //Le añade a la tabla una columna nueva y vacía, que guardará texto.

            foreach (DataRow fila in tabla.Rows) 
            {
                int id = Convert.ToInt32(fila["idEstudiante"]);
                fila["nombreEstudiante"] = EstudianteNegocio.ObtenerNombre(id);
            }
        }


        //En este metodo se evita que los datos se salgan del rango de las notas 
        private static void ValidarRango(decimal nota)
        {
            if (nota < 0 || nota > 100)
            {
                throw new Exception("Las calificaciones debe estar entre 0 y 100.");//respecto al throw: Al ejecutarse, el método se detiene ahí mismo,
                                                                                    //las líneas de abajo no se ejecutan (Bueno, como refactorize
                                                                                    //ya no hay nada debajo, dejo esto a modo de nota personal)
            }
        }

        public static void Agregar(Calificacion calificacion) //recibo un objeto de tipo Calificacion y aquí lo llamaré calificacion
        {
            
            ValidarRango(calificacion.Nota);

            if (CalificacionDatos.Existe(calificacion.IdEstudiante, calificacion.IdMateria)) //no repetir la combinacion estudiante + materia.
            {
                throw new Exception("Este estudiante ya tiene su nota asignada en esta materia.");
            }
            CalificacionDatos.AgregarCalificacion(calificacion.IdEstudiante, calificacion.IdMateria, calificacion.Nota);// Esta línea es la que realmente inserta en SQL.
        }

        public static void Eliminar(int idCalificaciones) //similar a mi metodo de Listar(), solo llama a la capa datos
        {
           CalificacionDatos.EliminarCalificacion(idCalificaciones);
        }

        public static void Modificar(Calificacion calificacion)
        {
           
            ValidarRango(calificacion.Nota);

            CalificacionDatos.ModificarCalificacion(calificacion.IdCalificaciones,calificacion.Nota);
        }

        public static decimal CalcularPromedio(DataTable tabla)
        {
            if (tabla.Rows.Count == 0) //tabla.Rows es la colección de filas y .Count dice cuántas hay.
                                       //Si hay cero el estudiante no tiene notas y
                                       //no se puede promediar porque estaria dividiendo entre 0
            {
                throw new Exception("Este estudiante no tiene calificaciones.");
                
            }
            decimal suma = 0;
            foreach (DataRow fila in tabla.Rows) 
            {
                suma = suma + Convert.ToDecimal(fila["nota"]); //La celda devuelve un tipo genérico, por eso Convert.ToDecimal la vuelve número.
            }
            return suma / tabla.Rows.Count;

        }

        public static string ObtenerCondicion(decimal promedio) 
        {
            if (promedio >= 70)
            {
                return "Aprobado";
            }
            else
            {
                return "Reprobado";
            }
        }



    }
}
