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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTramite = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lstCola = new System.Windows.Forms.ListBox();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.lblCodigo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trámite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.gbListado = new System.Windows.Forms.GroupBox();
            this.lblCodigo2 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblTramite2 = new System.Windows.Forms.Label();
            this.gbElEliminado = new System.Windows.Forms.GroupBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblNombre1 = new System.Windows.Forms.Label();
            this.lblTramite1 = new System.Windows.Forms.Label();
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
            this.txtCodigo.Location = new System.Drawing.Point(144, 13);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(51, 22);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(93, 52);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(102, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // txtTramite
            // 
            this.txtTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTramite.Location = new System.Drawing.Point(93, 92);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(102, 22);
            this.txtTramite.TabIndex = 2;
            this.txtTramite.TextChanged += new System.EventHandler(this.txtTramite_TextChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(8, 16);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(6, 51);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite.Location = new System.Drawing.Point(6, 95);
            this.lblTramite.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(56, 16);
            this.lblTramite.TabIndex = 5;
            this.lblTramite.Text = "Trámite:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(9, 131);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(186, 25);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(17, 131);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(186, 25);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lstCola
            // 
            this.lstCola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCola.FormattingEnabled = true;
            this.lstCola.ItemHeight = 16;
            this.lstCola.Location = new System.Drawing.Point(13, 33);
            this.lstCola.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.lstCola.Name = "lstCola";
            this.lstCola.Size = new System.Drawing.Size(228, 212);
            this.lstCola.TabIndex = 8;
            // 
            // dgvCola
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCola.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lblCodigo1,
            this.Nombre,
            this.Trámite});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCola.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCola.Location = new System.Drawing.Point(283, 33);
            this.dgvCola.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.RowHeadersWidth = 82;
            this.dgvCola.Size = new System.Drawing.Size(449, 207);
            this.dgvCola.TabIndex = 9;
            // 
            // lblCodigo1
            // 
            this.lblCodigo1.HeaderText = "Codigo";
            this.lblCodigo1.MinimumWidth = 10;
            this.lblCodigo1.Name = "lblCodigo1";
            this.lblCodigo1.Width = 200;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 10;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // Trámite
            // 
            this.Trámite.HeaderText = "Tramite";
            this.Trámite.MinimumWidth = 10;
            this.Trámite.Name = "Trámite";
            this.Trámite.Width = 200;
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
            this.gbNuevoElemento.Location = new System.Drawing.Point(329, 13);
            this.gbNuevoElemento.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.gbNuevoElemento.Name = "gbNuevoElemento";
            this.gbNuevoElemento.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.gbNuevoElemento.Size = new System.Drawing.Size(221, 175);
            this.gbNuevoElemento.TabIndex = 10;
            this.gbNuevoElemento.TabStop = false;
            this.gbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // gbListado
            // 
            this.gbListado.Controls.Add(this.lstCola);
            this.gbListado.Controls.Add(this.dgvCola);
            this.gbListado.Location = new System.Drawing.Point(10, 216);
            this.gbListado.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.gbListado.Name = "gbListado";
            this.gbListado.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.gbListado.Size = new System.Drawing.Size(763, 287);
            this.gbListado.TabIndex = 11;
            this.gbListado.TabStop = false;
            this.gbListado.Text = "Listado en una Lista y una Grilla";
            // 
            // lblCodigo2
            // 
            this.lblCodigo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCodigo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo2.Location = new System.Drawing.Point(135, 16);
            this.lblCodigo2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCodigo2.Name = "lblCodigo2";
            this.lblCodigo2.Size = new System.Drawing.Size(51, 22);
            this.lblCodigo2.TabIndex = 12;
            this.lblCodigo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre2
            // 
            this.lblNombre2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre2.Location = new System.Drawing.Point(95, 51);
            this.lblNombre2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(91, 22);
            this.lblNombre2.TabIndex = 13;
            this.lblNombre2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTramite2
            // 
            this.lblTramite2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTramite2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite2.Location = new System.Drawing.Point(95, 92);
            this.lblTramite2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTramite2.Name = "lblTramite2";
            this.lblTramite2.Size = new System.Drawing.Size(91, 22);
            this.lblTramite2.TabIndex = 14;
            this.lblTramite2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbElEliminado
            // 
            this.gbElEliminado.Controls.Add(this.lblCod);
            this.gbElEliminado.Controls.Add(this.lblNombre1);
            this.gbElEliminado.Controls.Add(this.lblTramite1);
            this.gbElEliminado.Controls.Add(this.lblCodigo2);
            this.gbElEliminado.Controls.Add(this.lblTramite2);
            this.gbElEliminado.Controls.Add(this.lblNombre2);
            this.gbElEliminado.Controls.Add(this.btnEliminar);
            this.gbElEliminado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbElEliminado.Location = new System.Drawing.Point(598, 13);
            this.gbElEliminado.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.gbElEliminado.Name = "gbElEliminado";
            this.gbElEliminado.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.gbElEliminado.Size = new System.Drawing.Size(221, 175);
            this.gbElEliminado.TabIndex = 15;
            this.gbElEliminado.TabStop = false;
            this.gbElEliminado.Text = "Elemento Eliminado";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(3, 16);
            this.lblCod.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(51, 16);
            this.lblCod.TabIndex = 18;
            this.lblCod.Text = "Código";
            // 
            // lblNombre1
            // 
            this.lblNombre1.AutoSize = true;
            this.lblNombre1.Location = new System.Drawing.Point(2, 51);
            this.lblNombre1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblNombre1.Name = "lblNombre1";
            this.lblNombre1.Size = new System.Drawing.Size(56, 16);
            this.lblNombre1.TabIndex = 16;
            this.lblNombre1.Text = "Nombre";
            // 
            // lblTramite1
            // 
            this.lblTramite1.AutoSize = true;
            this.lblTramite1.Location = new System.Drawing.Point(3, 95);
            this.lblTramite1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblTramite1.Name = "lblTramite1";
            this.lblTramite1.Size = new System.Drawing.Size(53, 16);
            this.lblTramite1.TabIndex = 17;
            this.lblTramite1.Text = "Trámite";
            // 
            // pBCola
            // 
            this.pBCola.Image = global::pryEDDiesenbergM.Properties.Resources.b10;
            this.pBCola.Location = new System.Drawing.Point(10, 13);
            this.pBCola.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.pBCola.Name = "pBCola";
            this.pBCola.Size = new System.Drawing.Size(269, 195);
            this.pBCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBCola.TabIndex = 16;
            this.pBCola.TabStop = false;
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(832, 530);
            this.Controls.Add(this.pBCola);
            this.Controls.Add(this.gbElEliminado);
            this.Controls.Add(this.gbListado);
            this.Controls.Add(this.gbNuevoElemento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "frmCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cola";
            this.Load += new System.EventHandler(this.frmCola_Load);
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
        private System.Windows.Forms.Button btnEliminar;
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
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.PictureBox pBCola;
    }
}