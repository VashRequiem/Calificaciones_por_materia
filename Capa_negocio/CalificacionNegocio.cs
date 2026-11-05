
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
            return CalificacionDatos.ListarCalificacion();
        }

        public static DataTable ListarPorEstudiante(int idEstudiante)
        {
            return CalificacionDatos.ListarPorEstudiante(idEstudiante);
        }


        //En este metodo evitamos que los datos se salgan del rango de las notas 
        public static void Agregar(Calificacion calificacion) //recibo un objeto de tipo Calificacion y aquí lo llamaré calificacion
        {
            if (calificacion.Nota < 0 || calificacion.Nota > 100)
            {
                throw new Exception("Las calificaciones deben estar entre 0 y 100."); //resoecto al throw: Al ejecutarse, el método se detiene ahí mismo,
                                                                                        //las líneas de abajo no se ejecutan, y el mensaje sale hacia arriba, de capa en capa, hasta encontrar un catch.
            }
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
            if (calificacion.Nota < 0 || calificacion.Nota >100) 
            {
                throw new Exception("Las calificaciones debe estar entre 0 y 100.");
            }
            CalificacionDatos.ModificarCalificacion(calificacion.IdCalificaciones,calificacion.Nota);
        }

        public static decimal CalcularPromedio(DataTable tabla)
        {
            if (tabla.Rows.Count == 0) 
            {
                throw new Exception("Este estudiante no tiene calificaciones.");
                
            }
            decimal suma = 0;
            foreach (DataRow fila in tabla.Rows) 
            {
                suma = suma + Convert.ToDecimal(fila["nota"]);
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
