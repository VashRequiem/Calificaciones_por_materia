namespace Calificaciones_por_materia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvMateria = new DataGridView();
            btnListar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMateria).BeginInit();
            SuspendLayout();
            // 
            // dgvMateria
            // 
            dgvMateria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMateria.Location = new Point(58, 102);
            dgvMateria.Name = "dgvMateria";
            dgvMateria.Size = new Size(240, 150);
            dgvMateria.TabIndex = 0;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(58, 73);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar materia";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnListar);
            Controls.Add(dgvMateria);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvMateria).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMateria;
        private Button btnListar;
    }
}
