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
            this.SuspendLayout();
            // 
            // lblYo
            // 
            this.lblYo.AutoSize = true;
            this.lblYo.BackColor = System.Drawing.Color.Lavender;
            this.lblYo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYo.Location = new System.Drawing.Point(160, 75);
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
            this.lblMateria.Location = new System.Drawing.Point(221, 142);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(597, 37);
            this.lblMateria.TabIndex = 1;
            this.lblMateria.Text = "Materia: Estructura de Datos - Cátedra B";
            // 
            // txtTP
            // 
            this.txtTP.BackColor = System.Drawing.Color.Lavender;
            this.txtTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTP.Location = new System.Drawing.Point(133, 219);
            this.txtTP.Name = "txtTP";
            this.txtTP.Size = new System.Drawing.Size(780, 44);
            this.txtTP.TabIndex = 2;
            this.txtTP.Text = "Este sistema fue desarrollado para el trabajo práctico ";
            // 
            // txtTP2
            // 
            this.txtTP2.BackColor = System.Drawing.Color.Lavender;
            this.txtTP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTP2.Location = new System.Drawing.Point(167, 260);
            this.txtTP2.Name = "txtTP2";
            this.txtTP2.Size = new System.Drawing.Size(696, 44);
            this.txtTP2.TabIndex = 3;
            this.txtTP2.Text = "que se va a llevar a cabo en el primer semestre";
            // 
            // frmDatosDesarrollador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1046, 408);
            this.Controls.Add(this.txtTP2);
            this.Controls.Add(this.txtTP);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblYo);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmDatosDesarrollador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Desarrollador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYo;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.TextBox txtTP;
        private System.Windows.Forms.TextBox txtTP2;
    }
}