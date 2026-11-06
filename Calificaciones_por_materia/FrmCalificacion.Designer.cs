namespace CapaPresentacion
{
    partial class FrmCalificacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvCalificacion = new DataGridView();
            btnListar = new Button();
            cboMateria = new ComboBox();
            cboEstudiante = new ComboBox();
            btnAgregar = new Button();
            txtNota = new TextBox();
            lblNota = new Label();
            btnEliminar = new Button();
            btnModificar = new Button();
            btnConsultar = new Button();
            lblPromedio = new Label();
            lblCondicion = new Label();
            lblEstudiante = new Label();
            label2 = new Label();
            lblCalificaciones = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCalificacion).BeginInit();
            SuspendLayout();
            // 
            // dgvCalificacion
            // 
            dgvCalificacion.BackgroundColor = Color.Linen;
            dgvCalificacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalificacion.Location = new Point(52, 279);
            dgvCalificacion.Name = "dgvCalificacion";
            dgvCalificacion.Size = new Size(593, 200);
            dgvCalificacion.TabIndex = 0;
            dgvCalificacion.CellClick += dgvCalificacion_CellClick;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(300, 140);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // cboMateria
            // 
            cboMateria.FormattingEnabled = true;
            cboMateria.Location = new Point(191, 99);
            cboMateria.Name = "cboMateria";
            cboMateria.Size = new Size(121, 23);
            cboMateria.TabIndex = 2;
            cboMateria.SelectedIndexChanged += cboMateria_SelectedIndexChanged;
            // 
            // cboEstudiante
            // 
            cboEstudiante.FormattingEnabled = true;
            cboEstudiante.Location = new Point(57, 100);
            cboEstudiante.Name = "cboEstudiante";
            cboEstudiante.Size = new Size(121, 23);
            cboEstudiante.TabIndex = 3;
            cboEstudiante.SelectedIndexChanged += cboEstudiante_SelectedIndexChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(57, 140);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtNota
            // 
            txtNota.Location = new Point(318, 99);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(57, 23);
            txtNota.TabIndex = 5;
            // 
            // lblNota
            // 
            lblNota.AutoSize = true;
            lblNota.Location = new Point(318, 81);
            lblNota.Name = "lblNota";
            lblNota.Size = new Size(33, 15);
            lblNota.TabIndex = 6;
            lblNota.Text = "Nota";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.PaleVioletRed;
            btnEliminar.Location = new Point(219, 140);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(138, 140);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(505, 94);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(86, 23);
            btnConsultar.TabIndex = 9;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(518, 125);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(59, 15);
            lblPromedio.TabIndex = 10;
            lblPromedio.Text = "Promedio";
            // 
            // lblCondicion
            // 
            lblCondicion.AutoSize = true;
            lblCondicion.Location = new Point(518, 140);
            lblCondicion.Name = "lblCondicion";
            lblCondicion.Size = new Size(62, 15);
            lblCondicion.TabIndex = 11;
            lblCondicion.Text = "Condicion";
            // 
            // lblEstudiante
            // 
            lblEstudiante.AutoSize = true;
            lblEstudiante.Location = new Point(52, 82);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(62, 15);
            lblEstudiante.TabIndex = 12;
            lblEstudiante.Text = "Estudiante";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 81);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 13;
            label2.Text = "Materia";
            // 
            // lblCalificaciones
            // 
            lblCalificaciones.AutoSize = true;
            lblCalificaciones.BackColor = Color.Snow;
            lblCalificaciones.Location = new Point(52, 252);
            lblCalificaciones.Name = "lblCalificaciones";
            lblCalificaciones.Size = new Size(80, 15);
            lblCalificaciones.TabIndex = 14;
            lblCalificaciones.Text = "Calificaciones";
            // 
            // FrmCalificacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(687, 551);
            Controls.Add(lblCalificaciones);
            Controls.Add(label2);
            Controls.Add(lblEstudiante);
            Controls.Add(lblCondicion);
            Controls.Add(lblPromedio);
            Controls.Add(btnConsultar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(lblNota);
            Controls.Add(txtNota);
            Controls.Add(btnAgregar);
            Controls.Add(cboEstudiante);
            Controls.Add(cboMateria);
            Controls.Add(btnListar);
            Controls.Add(dgvCalificacion);
            Name = "FrmCalificacion";
            Text = "Registro de Calificaciones";
            Load += FrmCalificacion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCalificacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCalificacion;
        private Button btnListar;
        private ComboBox cboMateria;
        private ComboBox cboEstudiante;
        private Button btnAgregar;
        private TextBox txtNota;
        private Label lblNota;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnConsultar;
        private Label lblPromedio;
        private Label lblCondicion;
        private Label lblEstudiante;
        private Label label2;
        private Label lblCalificaciones;
    }
}