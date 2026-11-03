using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaDatos
{
    public class EstudianteDatos
    {
        public static DataTable ListarEstudiante() 
        {
            var tabla = new DataTable();
            using (var conexion = new SqlConnection(Conexion.Cadena))
            using (var comando = new SqlCommand("SELECT idEstudiante FROM Estudiante", conexion))
            using (var adaptador = new SqlDataAdapter(comando)) 
            {
                adaptador.Fill(tabla);
            }
            return tabla;
        }
    }
}
