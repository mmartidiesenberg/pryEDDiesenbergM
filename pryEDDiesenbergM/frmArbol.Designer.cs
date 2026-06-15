namespace pryEDDiesenbergM
{
    partial class frmArbol
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
            this.gbNuevoElemento = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTramite = new System.Windows.Forms.Label();
            this.gbEAEliminar = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.gbListadoArbol = new System.Windows.Forms.GroupBox();
            this.dgvArbol = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbPostOrden = new System.Windows.Forms.RadioButton();
            this.rbPreOrden = new System.Windows.Forms.RadioButton();
            this.rbInOrden = new System.Windows.Forms.RadioButton();
            this.tvArbol = new System.Windows.Forms.TreeView();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.gbNuevoElemento.SuspendLayout();
            this.gbEAEliminar.SuspendLayout();
            this.gbListadoArbol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbol)).BeginInit();
            this.SuspendLayout();
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
            this.gbNuevoElemento.Location = new System.Drawing.Point(622, 21);
            this.gbNuevoElemento.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbNuevoElemento.Name = "gbNuevoElemento";
            this.gbNuevoElemento.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbNuevoElemento.Size = new System.Drawing.Size(442, 450);
            this.gbNuevoElemento.TabIndex = 14;
            this.gbNuevoElemento.TabStop = false;
            this.gbNuevoElemento.Text = "Nuevo Elemento";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(12, 58);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(101, 30);
            this.lblCodigo.TabIndex = 3;
            this.lblCodigo.Text = "Código:";
            // 
            // txtTramite
            // 
            this.txtTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTramite.Location = new System.Drawing.Point(186, 254);
            this.txtTramite.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(200, 37);
            this.txtTramite.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(288, 52);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(98, 37);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(186, 146);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 37);
            this.txtNombre.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(18, 352);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(372, 48);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 158);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(112, 30);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTramite.Location = new System.Drawing.Point(12, 265);
            this.lblTramite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(108, 30);
            this.lblTramite.TabIndex = 5;
            this.lblTramite.Text = "Trámite:";
            // 
            // gbEAEliminar
            // 
            this.gbEAEliminar.Controls.Add(this.btnEliminar);
            this.gbEAEliminar.Controls.Add(this.cmbCodigo);
            this.gbEAEliminar.Controls.Add(this.lblCod);
            this.gbEAEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEAEliminar.Location = new System.Drawing.Point(1134, 21);
            this.gbEAEliminar.Margin = new System.Windows.Forms.Padding(6);
            this.gbEAEliminar.Name = "gbEAEliminar";
            this.gbEAEliminar.Padding = new System.Windows.Forms.Padding(6);
            this.gbEAEliminar.Size = new System.Drawing.Size(442, 337);
            this.gbEAEliminar.TabIndex = 15;
            this.gbEAEliminar.TabStop = false;
            this.gbEAEliminar.Text = "Elemento a Eliminar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(28, 252);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(372, 48);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(188, 177);
            this.cmbCodigo.Margin = new System.Windows.Forms.Padding(6);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(208, 38);
            this.cmbCodigo.TabIndex = 4;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(22, 183);
            this.lblCod.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(94, 30);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código";
            // 
            // gbListadoArbol
            // 
            this.gbListadoArbol.Controls.Add(this.dgvArbol);
            this.gbListadoArbol.Controls.Add(this.rbPostOrden);
            this.gbListadoArbol.Controls.Add(this.rbPreOrden);
            this.gbListadoArbol.Controls.Add(this.rbInOrden);
            this.gbListadoArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListadoArbol.Location = new System.Drawing.Point(64, 508);
            this.gbListadoArbol.Margin = new System.Windows.Forms.Padding(6);
            this.gbListadoArbol.Name = "gbListadoArbol";
            this.gbListadoArbol.Padding = new System.Windows.Forms.Padding(6);
            this.gbListadoArbol.Size = new System.Drawing.Size(1512, 396);
            this.gbListadoArbol.TabIndex = 16;
            this.gbListadoArbol.TabStop = false;
            this.gbListadoArbol.Text = "Listado del árbol";
            // 
            // dgvArbol
            // 
            this.dgvArbol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArbol.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colTramite});
            this.dgvArbol.Location = new System.Drawing.Point(326, 40);
            this.dgvArbol.Margin = new System.Windows.Forms.Padding(6);
            this.dgvArbol.Name = "dgvArbol";
            this.dgvArbol.RowHeadersWidth = 82;
            this.dgvArbol.Size = new System.Drawing.Size(1144, 302);
            this.dgvArbol.TabIndex = 3;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.MinimumWidth = 10;
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Width = 200;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 10;
            this.colNombre.Name = "colNombre";
            this.colNombre.Width = 200;
            // 
            // colTramite
            // 
            this.colTramite.HeaderText = "Tramite";
            this.colTramite.MinimumWidth = 10;
            this.colTramite.Name = "colTramite";
            this.colTramite.Width = 200;
            // 
            // rbPostOrden
            // 
            this.rbPostOrden.AutoSize = true;
            this.rbPostOrden.Location = new System.Drawing.Point(64, 265);
            this.rbPostOrden.Margin = new System.Windows.Forms.Padding(6);
            this.rbPostOrden.Name = "rbPostOrden";
            this.rbPostOrden.Size = new System.Drawing.Size(175, 34);
            this.rbPostOrden.TabIndex = 2;
            this.rbPostOrden.TabStop = true;
            this.rbPostOrden.Text = "Post-Orden";
            this.rbPostOrden.UseVisualStyleBackColor = true;
            // 
            // rbPreOrden
            // 
            this.rbPreOrden.AutoSize = true;
            this.rbPreOrden.Location = new System.Drawing.Point(64, 169);
            this.rbPreOrden.Margin = new System.Windows.Forms.Padding(6);
            this.rbPreOrden.Name = "rbPreOrden";
            this.rbPreOrden.Size = new System.Drawing.Size(164, 34);
            this.rbPreOrden.TabIndex = 1;
            this.rbPreOrden.TabStop = true;
            this.rbPreOrden.Text = "Pre-Orden";
            this.rbPreOrden.UseVisualStyleBackColor = true;
            // 
            // rbInOrden
            // 
            this.rbInOrden.AutoSize = true;
            this.rbInOrden.Location = new System.Drawing.Point(64, 73);
            this.rbInOrden.Margin = new System.Windows.Forms.Padding(6);
            this.rbInOrden.Name = "rbInOrden";
            this.rbInOrden.Size = new System.Drawing.Size(144, 34);
            this.rbInOrden.TabIndex = 0;
            this.rbInOrden.TabStop = true;
            this.rbInOrden.Text = "In-Orden";
            this.rbInOrden.UseVisualStyleBackColor = true;
            // 
            // tvArbol
            // 
            this.tvArbol.Location = new System.Drawing.Point(64, 23);
            this.tvArbol.Margin = new System.Windows.Forms.Padding(6);
            this.tvArbol.Name = "tvArbol";
            this.tvArbol.Size = new System.Drawing.Size(496, 444);
            this.tvArbol.TabIndex = 17;
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquilibrar.Location = new System.Drawing.Point(1134, 373);
            this.btnEquilibrar.Margin = new System.Windows.Forms.Padding(6);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(442, 44);
            this.btnEquilibrar.TabIndex = 18;
            this.btnEquilibrar.Text = "Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            // 
            // frmArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 975);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.tvArbol);
            this.Controls.Add(this.gbListadoArbol);
            this.Controls.Add(this.gbEAEliminar);
            this.Controls.Add(this.gbNuevoElemento);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmArbol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructuras Ramificadas - Árbol Binario";
            this.Load += new System.EventHandler(this.frmArbol_Load);
            this.gbNuevoElemento.ResumeLayout(false);
            this.gbNuevoElemento.PerformLayout();
            this.gbEAEliminar.ResumeLayout(false);
            this.gbEAEliminar.PerformLayout();
            this.gbListadoArbol.ResumeLayout(false);
            this.gbListadoArbol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArbol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNuevoElemento;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.GroupBox gbEAEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.GroupBox gbListadoArbol;
        private System.Windows.Forms.RadioButton rbPostOrden;
        private System.Windows.Forms.RadioButton rbPreOrden;
        private System.Windows.Forms.RadioButton rbInOrden;
        private System.Windows.Forms.DataGridView dgvArbol;
        private System.Windows.Forms.TreeView tvArbol;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTramite;
    }
}