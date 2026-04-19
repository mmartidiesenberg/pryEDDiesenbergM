namespace pryEDDiesenbergM
{
    partial class frmDatosDesarrollador
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
            this.lblYo = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblDatos2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYo
            // 
            this.lblYo.AutoSize = true;
            this.lblYo.BackColor = System.Drawing.Color.Lavender;
            this.lblYo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYo.Location = new System.Drawing.Point(160, 17);
            this.lblYo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYo.Name = "lblYo";
            this.lblYo.Size = new System.Drawing.Size(730, 37);
            this.lblYo.TabIndex = 0;
            this.lblYo.Text = " Mi nombre es Martina Diesenberg, DNI 47581556";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.BackColor = System.Drawing.Color.Lavender;
            this.lblMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.Location = new System.Drawing.Point(218, 88);
            this.lblMateria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(597, 37);
            this.lblMateria.TabIndex = 1;
            this.lblMateria.Text = "Materia: Estructura de Datos - Cátedra B";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryEDDiesenbergM.Properties.Resources.pngtree_smiling_cartoon_avatar_of_a_woman_with_brown_hair_png_image_16406613__1_;
            this.pictureBox1.Location = new System.Drawing.Point(288, 271);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 312);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(123, 158);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(784, 37);
            this.lblDatos.TabIndex = 5;
            this.lblDatos.Text = "Este sistema fue desarrollado para el trabajo práctico ";
            // 
            // lblDatos2
            // 
            this.lblDatos2.AutoSize = true;
            this.lblDatos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos2.Location = new System.Drawing.Point(160, 213);
            this.lblDatos2.Name = "lblDatos2";
            this.lblDatos2.Size = new System.Drawing.Size(687, 37);
            this.lblDatos2.TabIndex = 6;
            this.lblDatos2.Text = "que se va a llevar a cabo en el primer semestre";
            // 
            // frmDatosDesarrollador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1046, 606);
            this.Controls.Add(this.lblDatos2);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblYo);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmDatosDesarrollador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Desarrollador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYo;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblDatos2;
    }
}