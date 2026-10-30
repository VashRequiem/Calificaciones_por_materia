using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class MateriaDatos
    {
        public static DataTable ListarMateria()
        {
            var tabla = new DataTable();
            using (var conexion = new SqlConnection(Conexion.Cadena))
            using (var comando = new SqlCommand("select idMateria, nombreMateria, creditos FROM Materia", conexion))
            using (var adaptador = new SqlDataAdapter(comando))
            {
                adaptador.Fill(tabla);

            }
            return tabla;
        }
    }
}
