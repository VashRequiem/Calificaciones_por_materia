using CapaNegocio;

namespace Calificaciones_por_materia
{
    public partial class Form1 : Form
    {
        public Form1()
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
                MessageBox.Show("No se pudo cargar la lista: " + ex.Message);
            }
        }
    }
}
