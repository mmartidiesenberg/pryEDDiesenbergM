namespace pryEDDiesenbergM
{
    partial class frmCola
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTramite = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.gbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.lblCodigo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trámite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblTramite2 = new System.Windows.Forms.Label();
            this.gbElEliminado = new System.Windows.Forms.GroupBox();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.lblTramite1 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.pBCola = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            this.gbNuevoElemento.SuspendLayout();
            this.gbListado.SuspendLayout();
            this.gbElEliminado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBCola)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(120, 27);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(74, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(94, 73);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtTramite
            // 
            this.txtTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTramite.Location = new System.Drawing.Point(94, 113);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 22);
            this.txtTramite.TabIndex = 2;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(6, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(7, 73);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite.Location = new System.Drawing.Point(4, 116);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(56, 16);
            this.lblTramite.TabIndex = 5;
            this.lblTramite.Text = "Trámite:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(9, 144);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(185, 32);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(9, 144);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(185, 32);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // lstCola
            // 
            this.lstCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCola.FormattingEnabled = true;
            this.lstCola.ItemHeight = 16;
            this.lstCola.Location = new System.Drawing.Point(15, 21);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(199, 180);
            this.lstCola.TabIndex = 8;
            // 
            // dgvCola
            // 
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lblCodigo1,
            this.Nombre,
            this.Trámite});
            this.dgvCola.Location = new System.Drawing.Point(311, 21);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.Size = new System.Drawing.Size(343, 180);
            this.dgvCola.TabIndex = 9;
            // 
            // gbNuevoElemento
            // 
            this.gbNuevoElemento.Controls.Add(this.lblCodigo);
            this.gbNuevoElemento.Controls.Add(this.txtTramite);
            this.gbNuevoElemento.Controls.Add(this.txtCodigo);
            this.gbNuevoElemento.Controls.Add(this.txtNombre);
            this.gbNuevoElemento.Controls.Add(this.btnAgregar);
            this.gbNuevoElemento.Controls.Add(this.lblNombre);
            this.gbNuevoElemento.Controls.Add(this.lblTramite);
            this.gbNuevoElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNuevoElemento.Location = new System.Drawing.Point(266, 12);
            this.gbNuevoElemento.Name = "gbNuevoElemento";
            this.gbNuevoElemento.Size = new System.Drawing.Size(200, 182);
            this.gbNuevoElemento.TabIndex = 10;
            this.gbNuevoElemento.TabStop = false;
            this.gbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // lblCodigo1
            // 
            this.lblCodigo1.HeaderText = "Codigo";
            this.lblCodigo1.Name = "lblCodigo1";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Trámite
            // 
            this.Trámite.HeaderText = "Tramite";
            this.Trámite.Name = "Trámite";
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.lstCola);
            this.gbListado.Controls.Add(this.dgvCola);
            this.gbListado.Location = new System.Drawing.Point(22, 227);
            this.gbListado.Name = "gbListado";
            this.gbListado.Size = new System.Drawing.Size(694, 211);
            this.gbListado.TabIndex = 11;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado en una Lista y una Grilla";
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo2.Location = new System.Drawing.Point(120, 27);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(74, 22);
            this.lblCodigo2.TabIndex = 12;
            this.lblCodigo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre2
            // 
            this.lblNombre2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre2.Location = new System.Drawing.Point(94, 72);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(100, 22);
            this.lblNombre2.TabIndex = 13;
            this.lblNombre2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTramite2
            // 
            this.lblTramite2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramite2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite2.Location = new System.Drawing.Point(94, 113);
            this.lblTramite2.Name = "lblTramite2";
            this.lblTramite2.Size = new System.Drawing.Size(100, 22);
            this.lblTramite2.TabIndex = 14;
            this.lblTramite2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbElEliminado
            // 
            this.gbElEliminado.Controls.Add(this.lbl);
            this.gbElEliminado.Controls.Add(this.lblNombre1);
            this.gbElEliminado.Controls.Add(this.lblTramite1);
            this.gbElEliminado.Controls.Add(this.lblCodigo2);
            this.gbElEliminado.Controls.Add(this.lblTramite2);
            this.gbElEliminado.Controls.Add(this.lblNombre2);
            this.gbElEliminado.Controls.Add(this.btnBorrar);
            this.gbElEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbElEliminado.Location = new System.Drawing.Point(516, 12);
            this.gbElEliminado.Name = "gbElEliminado";
            this.gbElEliminado.Size = new System.Drawing.Size(200, 182);
            this.gbElEliminado.TabIndex = 15;
            this.gbElEliminado.TabStop = false;
            this.gbElEliminado.Text = "Elemento Eliminado";
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Location = new System.Drawing.Point(4, 73);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(56, 16);
            this.lblNombre1.TabIndex = 16;
            this.lblNombre1.Text = "Nombre";
            // 
            // lblTramite1
            // 
            this.lblTramite1.AutoSize = true;
            this.lblTramite1.Location = new System.Drawing.Point(4, 116);
            this.lblTramite1.Name = "lblTramite1";
            this.lblTramite1.Size = new System.Drawing.Size(53, 16);
            this.lblTramite1.TabIndex = 17;
            this.lblTramite1.Text = "Trámite";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(6, 33);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(51, 16);
            this.lbl.TabIndex = 18;
            this.lbl.Text = "Código";
            // 
            // pBCola
            // 
            this.pBCola.Image = global::pryEDDiesenbergM.Properties.Resources.b10;
            this.pBCola.Location = new System.Drawing.Point(22, 12);
            this.pBCola.Name = "pBCola";
            this.pBCola.Size = new System.Drawing.Size(195, 196);
            this.pBCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBCola.TabIndex = 16;
            this.pBCola.TabStop = false;
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.pBCola);
            this.Controls.Add(this.gbElEliminado);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbNuevoElemento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cola";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            this.gbNuevoElemento.ResumeLayout(false);
            this.gbNuevoElemento.PerformLayout();
            this.gbListado.ResumeLayout(false);
            this.gbElEliminado.ResumeLayout(false);
            this.gbElEliminado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBCola)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ListBox lstCola;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.GroupBox gbNuevoElemento;
        private System.Windows.Forms.DataGridViewTextBoxColumn lblCodigo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trámite;
        private System.Windows.Forms.GroupBox gbListado;
        private System.Windows.Forms.Label lblCodigo2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblTramite2;
        private System.Windows.Forms.GroupBox gbElEliminado;
        private System.Windows.Forms.Label lblNombre1;
        private System.Windows.Forms.Label lblTramite1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.PictureBox pBCola;
    }
}