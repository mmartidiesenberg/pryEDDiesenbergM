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
            this.txtTP = new System.Windows.Forms.TextBox();
            this.txtTP2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYo
            // 
            this.lblYo.AutoSize = true;
            this.lblYo.BackColor = System.Drawing.Color.Lavender;
            this.lblYo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYo.Location = new System.Drawing.Point(80, 9);
            this.lblYo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYo.Name = "lblYo";
            this.lblYo.Size = new System.Drawing.Size(363, 20);
            this.lblYo.TabIndex = 0;
            this.lblYo.Text = " Mi nombre es Martina Diesenberg, DNI 47581556";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.BackColor = System.Drawing.Color.Lavender;
            this.lblMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMateria.Location = new System.Drawing.Point(109, 46);
            this.lblMateria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(298, 20);
            this.lblMateria.TabIndex = 1;
            this.lblMateria.Text = "Materia: Estructura de Datos - Cátedra B";
            // 
            // txtTP
            // 
            this.txtTP.BackColor = System.Drawing.Color.Lavender;
            this.txtTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTP.Location = new System.Drawing.Point(65, 80);
            this.txtTP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTP.Name = "txtTP";
            this.txtTP.Size = new System.Drawing.Size(392, 26);
            this.txtTP.TabIndex = 2;
            this.txtTP.Text = "Este sistema fue desarrollado para el trabajo práctico ";
            // 
            // txtTP2
            // 
            this.txtTP2.BackColor = System.Drawing.Color.Lavender;
            this.txtTP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTP2.Location = new System.Drawing.Point(84, 110);
            this.txtTP2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTP2.Name = "txtTP2";
            this.txtTP2.Size = new System.Drawing.Size(350, 26);
            this.txtTP2.TabIndex = 3;
            this.txtTP2.Text = "que se va a llevar a cabo en el primer semestre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryEDDiesenbergM.Properties.Resources.pngtree_smiling_cartoon_avatar_of_a_woman_with_brown_hair_png_image_16406613__1_;
            this.pictureBox1.Location = new System.Drawing.Point(144, 141);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmDatosDesarrollador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(523, 315);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtTP2);
            this.Controls.Add(this.txtTP);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblYo);
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
        private System.Windows.Forms.TextBox txtTP;
        private System.Windows.Forms.TextBox txtTP2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}