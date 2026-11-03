using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class CalificacionDatos
    {
        public static DataTable ListarCalificacion()
        {
            var tabla = new DataTable();
            using (var conexion = new SqlConnection(Conexion.Cadena))
            using (var comando = new SqlCommand(@"SELECT c.idCalificaciones,c.idEstudiante, m.nombreMateria, c.nota
                                                  FROM Calificaciones c
                                                  INNER JOIN Materia m ON c.idMateria = m.idMateria", conexion))
            using (var adaptador = new SqlDataAdapter(comando))

            {
                adaptador.Fill(tabla);
            }
            return tabla;

        }

        public static void Agregar(int idEstudiante, int idMateria, decimal nota  ) 
        {
            using (var conexion = new SqlConnection(Conexion.Cadena))
            using (var comando = new SqlCommand(
                "INSERT INTO Calificaciones (idEstudiante, idMateria, nota) Values (@idEstudiante, @idMateria, @nota)" + conexion))
            {
                comando.Parameters.AddWithValue("@idEstudiante", idEstudiante);
                comando.Parameters.AddWithValue("@idMateria", idMateria);
                comando.Parameters.AddWithValue("@nota", nota);
            }
        }

        public static void Existe() 
        {

        }
    }
}
