using CapaNegocio;

namespace Calificaciones_por_materia
{
    public partial class FrmMateria : Form
    {
        public FrmMateria()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try 
            {
                dgvMateria.DataSource = MateriaNegocio.Listar();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("No se pudo cargar la lista de materias: " + ex.Message);
            }
        }
    }
}
