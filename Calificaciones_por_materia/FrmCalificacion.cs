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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal nota;
                if (!decimal.TryParse(txtNota.Text, out nota)) //decimal.TryParse intenta convertir el texto y
                                                               //responde true si pudo o false si no ( “abc” o con el campo vacío). 
                                                               //como estoy negando '!', es "si no puedes convertirlo"
                                                               //out es la forma de pedirle que deje un numero dentro de "Nota"
                {
                    MessageBox.Show("Escriba una nota valida (Solo numeros)");
                    return; //dentro del mismo if, salgo del metodo, es decir:
                            //luego de mostrar el mensaje, para salir del metodo y no seguir con un valor invalido 
                }
                //crea un objeto vacío a partir del molde y las tres líneas siguientes llenan sus propiedades
                //con lo que lee de los controles del FrmCalificacion.
                var calificacion = new Calificacion();
                calificacion.IdEstudiante = Convert.ToInt32(cboEstudiante.SelectedValue); //SelectedValue devuelve un tipo genérico (object)
                                                                                          //así que hay que convertirlo a int para que encaje con IdEstudiante.
                                                                                          //Ese valor es el id que guarda el combo por detrás.
                calificacion.IdMateria = Convert.ToInt32(cboMateria.SelectedValue);
                calificacion.Nota = nota;

                CalificacionNegocio.Agregar(calificacion); //Si negocio lanza un throw el método se detiene aquí y salta directo al catch
                //Esta parte me ayuda a limpiar los campos después de guardar y mostrar los datos actualizados en el grid.
                txtNota.Clear();
                dgvCalificacion.DataSource = CalificacionNegocio.Listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCalificacion.CurrentRow == null) 
                {
                    MessageBox.Show("Seleccione una fila de la lista");
                    return;
                }

                int id = Convert.ToInt32(dgvCalificacion.CurrentRow.Cells["idCalificaciones"].Value);

                DialogResult respuesta = MessageBox.Show("Eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes) 
                {
                    CalificacionNegocio.Eliminar(id);
                    dgvCalificacion.DataSource = CalificacionNegocio.Listar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
