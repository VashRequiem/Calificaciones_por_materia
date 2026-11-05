using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class CalificacionDatos
    {
        //los datatale me permiten tomar los datos de sql y llamarlos para que se muestren en los respectivos forms
        //Un DataTable es una tabla en memoria, y el método la devuelve hacia arriba para que el negocio y el formulario la muestren.
        public static DataTable ListarCalificacion()
        {
            var tabla = new DataTable();
            using (var conexion = new SqlConnection(Conexion.Cadena))
            using (var comando = new SqlCommand(@"SELECT c.idCalificaciones,c.idEstudiante, m.nombreMateria, c.nota
                                                  FROM Calificaciones c
                                                  INNER JOIN Materia m ON c.idMateria = m.idMateria", conexion))
            using (var adaptador = new SqlDataAdapter(comando))

            {
                adaptador.Fill(tabla); // Fill abre la conexión, ejecuta el SELECT y llena la tabla.
            }
            return tabla;

        }

        public static DataTable ListarPorEstudiante(int idEstudiante)
        {
            var tabla = new DataTable();
            using (var conexion = new SqlConnection(Conexion.Cadena))
            using (var comando = new SqlCommand(@"SELECT c.idCalificaciones,c.idEstudiante, m.nombreMateria, c.nota 
                                                FROM Calificaciones c INNER JOIN Materia m ON c.idMateria = m.idMateria 
                                                WHERE c.idEstudiante = @idEstudiante", conexion))
            using (var adaptador = new SqlDataAdapter(comando)) //con el adaptador no necesito utilizar conexion.Open()
            {
                comando.Parameters.AddWithValue("@idEstudiante",idEstudiante); // El parámetro se agrega antes de Fill porque Fill
                                                                               // es el que ejecuta la consulta. Si lo agrego después SQL la ejecuta sin el valor.
                adaptador.Fill(tabla);
            }
            return tabla;
        }

        // Aqui se inserta una calificación nueva.
        public static void AgregarCalificacion(int idEstudiante, int idMateria, decimal nota  ) 
        {
            using (var conexion = new SqlConnection(Conexion.Cadena))
            using (var comando = new SqlCommand(
                "INSERT INTO Calificaciones (idEstudiante, idMateria, nota) Values (@idEstudiante, @idMateria, @nota)", conexion))
            {
                // Los parámetros (@) evitan pegar valores dentro del texto SQL,
                // lo que previene la inyección SQL.
                comando.Parameters.AddWithValue("@idEstudiante", idEstudiante);
                comando.Parameters.AddWithValue("@idMateria", idMateria);
                comando.Parameters.AddWithValue("@nota", nota);

                conexion.Open();
                // ExecuteNonQuery se usa cuando NO esperas filas de vuelta.
                comando.ExecuteNonQuery();  //Aca ejecuta los INSERT , UPDATE, DELETE.
            }
        }


        // Devuelve true si ya existe una calificación para estudiante + materia.
        // Lo usa el negocio para dar un mensaje claro
        // antes de que el UNIQUE de la base de datos de error.
        public static bool Existe(int idEstudiante, int idMateria) 
        {
            int cantidad;
            using (var conexion = new SqlConnection(Conexion.Cadena))
            using (var comando = new SqlCommand(
                "SELECT COUNT(*) FROM Calificaciones WHERE idEstudiante = @idEstudiante AND idMateria = @idMateria", conexion))
            {
               
                comando.Parameters.AddWithValue("@idEstudiante", idEstudiante);
                comando.Parameters.AddWithValue("@idMateria", idMateria);

                conexion.Open();
                cantidad = Convert.ToInt32(comando.ExecuteScalar());   //ExecuteScalar devuelve UN solo valor(la primera celda del resultado):
                                                                       // aquí, el conteo de coincidencias.
            }
            if (cantidad > 0) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void EliminarCalificacion(int idCalificaciones) 
        {
            using (var conexion = new SqlConnection(Conexion.Cadena))
            using (var comando = new SqlCommand(
                "DELETE FROM Calificaciones WHERE idCalificaciones = @idCalificaciones", conexion))
            {
                comando.Parameters.AddWithValue("@idCalificaciones", idCalificaciones);
                conexion.Open();
                comando.ExecuteNonQuery();
            }

        }

        public static void ModificarCalificacion(int idCalificaciones, decimal nota)
        {
            using (var conexion = new SqlConnection(Conexion.Cadena))
            using (var comando = new SqlCommand(
                "UPDATE Calificaciones SET nota = @nota WHERE idCalificaciones = @idCalificaciones", conexion))
            {
                comando.Parameters.AddWithValue("@idCalificaciones",idCalificaciones);
                comando.Parameters.AddWithValue("@nota", nota);
                conexion.Open();
                comando.ExecuteNonQuery();
            }
        }


    }
}
