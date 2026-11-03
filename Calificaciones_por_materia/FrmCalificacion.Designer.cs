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
            ((System.ComponentModel.ISupportInitialize)dgvCalificacion).BeginInit();
            SuspendLayout();
            // 
            // dgvCalificacion
            // 
            dgvCalificacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalificacion.Location = new Point(107, 152);
            dgvCalificacion.Name = "dgvCalificacion";
            dgvCalificacion.Size = new Size(184, 247);
            dgvCalificacion.TabIndex = 0;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(107, 111);
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
            cboMateria.Location = new Point(398, 120);
            cboMateria.Name = "cboMateria";
            cboMateria.Size = new Size(121, 23);
            cboMateria.TabIndex = 2;
            cboMateria.SelectedIndexChanged += cboMateria_SelectedIndexChanged;
            // 
            // cboEstudiante
            // 
            cboEstudiante.FormattingEnabled = true;
            cboEstudiante.Location = new Point(549, 123);
            cboEstudiante.Name = "cboEstudiante";
            cboEstudiante.Size = new Size(121, 23);
            cboEstudiante.TabIndex = 3;
            cboEstudiante.SelectedIndexChanged += cboEstudiante_SelectedIndexChanged;
            // 
            // FrmCalificacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboEstudiante);
            Controls.Add(cboMateria);
            Controls.Add(btnListar);
            Controls.Add(dgvCalificacion);
            Name = "FrmCalificacion";
            Text = "Registro de Calificaciones";
            Load += FrmCalificacion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCalificacion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCalificacion;
        private Button btnListar;
        private ComboBox cboMateria;
        private ComboBox cboEstudiante;
    }
}