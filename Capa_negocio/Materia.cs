namespace CapaNegocio
{
    public class Materia
    {
        public int IdMateria { get; set; }
        public string NombreMateria { get; set; } = "";  //puse las comillas para quitar la advertencia de que necesita un valor not null
        public int Creditos { get; set; }

    }
}
