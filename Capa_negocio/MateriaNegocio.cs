using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CapaNegocio
{
    public class MateriaNegocio
    {
        public static DataTable Listar() 
        {
            
            return MateriaDatos.ListarMateria();
        }
    }
}
