using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmCalificacion : Form
    {
        public FrmCalificacion()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvCalificacion.DataSource = CalificacionNegocio.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la lista de calificaciones: " + ex.Message);
            }
        }

        private void cboMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO: Comprobando que se guardan los Ids con las materias de forma correcta
            // La comprobacion funciona, mostrando el id asociado a cada materia seleccionada
             /*
             if (cboMateria.SelectedValue != null) 
             {
                 MessageBox.Show(cboMateria.SelectedValue.ToString());
             }*/
            

        }

        private void FrmCalificacion_Load(object sender, EventArgs e)
        {
            try
            {
                cboMateria.DisplayMember = "nombreMateria";
                cboMateria.ValueMember = "idMateria";
                cboMateria.DataSource = MateriaNegocio.Listar();

                cboEstudiante.DisplayMember = "nombreEstudiante";
                cboEstudiante.ValueMember = "idEstudiante";
                cboEstudiante.DataSource = EstudianteNegocio.Listar();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los datos: " + ex.Message);
            }
        }

        private void cboEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (cboEstudiante.SelectedValue != null)
            {
                MessageBox.Show(cboEstudiante.SelectedValue.ToString());
            }*/
        }
    }
}
