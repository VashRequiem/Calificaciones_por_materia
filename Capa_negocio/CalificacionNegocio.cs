
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


        //En este metodo evitamos que los datos se salgan del rango de las notas 
        public static void Agregar(Calificacion calificacion) //recibo un objeto de tipo Calificacion y aquí lo llamaré calificacion
        {
            if (calificacion.Nota < 0 || calificacion.Nota > 100)
            {
                throw new Exception("Las calificaciones tienen que ser entre 0 y 100"); //resoecto al throw: Al ejecutarse, el método se detiene ahí mismo,
                                                                                        //las líneas de abajo no se ejecutan, y el mensaje sale hacia arriba, de capa en capa, hasta encontrar un catch.
            }
            if (CalificacionDatos.Existe(calificacion.IdEstudiante, calificacion.IdMateria)) //no repetir la combinacion estudiante + materia.
            {
                throw new Exception("Este estudiante ya tiene su nota asignada en esta materia");
            }
            CalificacionDatos.Agregar(calificacion.IdEstudiante, calificacion.IdMateria, calificacion.Nota);// Esta línea es la que realmente inserta en SQL.
        }

        public static DataTable Eliminar()
        {
            return CalificacionDatos.ListarCalificacion();
        }
    }
}
