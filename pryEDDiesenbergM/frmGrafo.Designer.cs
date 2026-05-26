namespace pryEDDiesenbergM
{
    partial class frmGrafo
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
            this.gbCargaDatos = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cmbDestinoA = new System.Windows.Forms.ComboBox();
            this.btnBorrarTodo = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.cmbOrigenA = new System.Windows.Forms.ComboBox();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblPrecio2 = new System.Windows.Forms.Label();
            this.cmbDestinoE = new System.Windows.Forms.ComboBox();
            this.cmbOrigenE = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbListarViajes = new System.Windows.Forms.GroupBox();
            this.dgvGrafo = new System.Windows.Forms.DataGridView();
            this.btnVerViajes = new System.Windows.Forms.Button();
            this.btnListarOrigenes = new System.Windows.Forms.Button();
            this.btnListarDestinos = new System.Windows.Forms.Button();
            this.cmbDestinoC = new System.Windows.Forms.ComboBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbOrigenC = new System.Windows.Forms.ComboBox();
            this.gbCargaDatos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbListarViajes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCargaDatos
            // 
            this.gbCargaDatos.Controls.Add(this.txtPrecio);
            this.gbCargaDatos.Controls.Add(this.cmbDestinoA);
            this.gbCargaDatos.Controls.Add(this.btnBorrarTodo);
            this.gbCargaDatos.Controls.Add(this.btnCargar);
            this.gbCargaDatos.Controls.Add(this.cmbOrigenA);
            this.gbCargaDatos.Controls.Add(this.lblOrigen);
            this.gbCargaDatos.Controls.Add(this.lblDestino);
            this.gbCargaDatos.Controls.Add(this.lblPrecio);
            this.gbCargaDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCargaDatos.Location = new System.Drawing.Point(266, 12);
            this.gbCargaDatos.Name = "gbCargaDatos";
            this.gbCargaDatos.Size = new System.Drawing.Size(246, 185);
            this.gbCargaDatos.TabIndex = 1;
            this.gbCargaDatos.TabStop = false;
            this.gbCargaDatos.Text = "Carga de Datos";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(68, 112);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(159, 22);
            this.txtPrecio.TabIndex = 2;
            // 
            // cmbDestinoA
            // 
            this.cmbDestinoA.FormattingEnabled = true;
            this.cmbDestinoA.Location = new System.Drawing.Point(68, 70);
            this.cmbDestinoA.Name = "cmbDestinoA";
            this.cmbDestinoA.Size = new System.Drawing.Size(159, 24);
            this.cmbDestinoA.TabIndex = 8;
            // 
            // btnBorrarTodo
            // 
            this.btnBorrarTodo.Location = new System.Drawing.Point(9, 140);
            this.btnBorrarTodo.Name = "btnBorrarTodo";
            this.btnBorrarTodo.Size = new System.Drawing.Size(107, 30);
            this.btnBorrarTodo.TabIndex = 12;
            this.btnBorrarTodo.Text = "Borrar Todo";
            this.btnBorrarTodo.UseVisualStyleBackColor = true;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(133, 140);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(107, 30);
            this.btnCargar.TabIndex = 13;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // cmbOrigenA
            // 
            this.cmbOrigenA.FormattingEnabled = true;
            this.cmbOrigenA.Location = new System.Drawing.Point(68, 29);
            this.cmbOrigenA.Name = "cmbOrigenA";
            this.cmbOrigenA.Size = new System.Drawing.Size(159, 24);
            this.cmbOrigenA.TabIndex = 9;
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(6, 37);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(50, 16);
            this.lblOrigen.TabIndex = 2;
            this.lblOrigen.Text = "Origen:";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(6, 73);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(56, 16);
            this.lblDestino.TabIndex = 3;
            this.lblDestino.Text = "Destino:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(6, 112);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(49, 16);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConsultar);
            this.groupBox2.Controls.Add(this.btnBorrar);
            this.groupBox2.Controls.Add(this.lblPrecio2);
            this.groupBox2.Controls.Add(this.cmbDestinoE);
            this.groupBox2.Controls.Add(this.cmbOrigenE);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(528, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 185);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta de Datos";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(9, 140);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(107, 30);
            this.btnConsultar.TabIndex = 14;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(133, 140);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(107, 30);
            this.btnBorrar.TabIndex = 15;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // lblPrecio2
            // 
            this.lblPrecio2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrecio2.Location = new System.Drawing.Point(68, 112);
            this.lblPrecio2.Name = "lblPrecio2";
            this.lblPrecio2.Size = new System.Drawing.Size(158, 23);
            this.lblPrecio2.TabIndex = 3;
            // 
            // cmbDestinoE
            // 
            this.cmbDestinoE.FormattingEnabled = true;
            this.cmbDestinoE.Location = new System.Drawing.Point(68, 70);
            this.cmbDestinoE.Name = "cmbDestinoE";
            this.cmbDestinoE.Size = new System.Drawing.Size(158, 24);
            this.cmbDestinoE.TabIndex = 10;
            // 
            // cmbOrigenE
            // 
            this.cmbOrigenE.FormattingEnabled = true;
            this.cmbOrigenE.Location = new System.Drawing.Point(68, 29);
            this.cmbOrigenE.Name = "cmbOrigenE";
            this.cmbOrigenE.Size = new System.Drawing.Size(158, 24);
            this.cmbOrigenE.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio:";
            // 
            // gbListarViajes
            // 
            this.gbListarViajes.Controls.Add(this.dgvGrafo);
            this.gbListarViajes.Controls.Add(this.btnVerViajes);
            this.gbListarViajes.Controls.Add(this.btnListarOrigenes);
            this.gbListarViajes.Controls.Add(this.btnListarDestinos);
            this.gbListarViajes.Controls.Add(this.cmbDestinoC);
            this.gbListarViajes.Controls.Add(this.cmbOrigenC);
            this.gbListarViajes.Controls.Add(this.lblHasta);
            this.gbListarViajes.Controls.Add(this.lblDesde);
            this.gbListarViajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListarViajes.Location = new System.Drawing.Point(12, 203);
            this.gbListarViajes.Name = "gbListarViajes";
            this.gbListarViajes.Size = new System.Drawing.Size(776, 249);
            this.gbListarViajes.TabIndex = 2;
            this.gbListarViajes.TabStop = false;
            this.gbListarViajes.Text = "Listar Viajes";
            // 
            // dgvGrafo
            // 
            this.dgvGrafo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrafo.Location = new System.Drawing.Point(12, 48);
            this.dgvGrafo.Name = "dgvGrafo";
            this.dgvGrafo.Size = new System.Drawing.Size(758, 195);
            this.dgvGrafo.TabIndex = 7;
            // 
            // btnVerViajes
            // 
            this.btnVerViajes.Location = new System.Drawing.Point(631, 18);
            this.btnVerViajes.Name = "btnVerViajes";
            this.btnVerViajes.Size = new System.Drawing.Size(139, 23);
            this.btnVerViajes.TabIndex = 6;
            this.btnVerViajes.Text = "Ver todos los Viajes";
            this.btnVerViajes.UseVisualStyleBackColor = true;
            // 
            // btnListarOrigenes
            // 
            this.btnListarOrigenes.Location = new System.Drawing.Point(487, 18);
            this.btnListarOrigenes.Name = "btnListarOrigenes";
            this.btnListarOrigenes.Size = new System.Drawing.Size(124, 24);
            this.btnListarOrigenes.TabIndex = 5;
            this.btnListarOrigenes.Text = "Listar Orígenes";
            this.btnListarOrigenes.UseVisualStyleBackColor = true;
            // 
            // btnListarDestinos
            // 
            this.btnListarDestinos.Location = new System.Drawing.Point(186, 19);
            this.btnListarDestinos.Name = "btnListarDestinos";
            this.btnListarDestinos.Size = new System.Drawing.Size(124, 23);
            this.btnListarDestinos.TabIndex = 4;
            this.btnListarDestinos.Text = "Listar Destinos";
            this.btnListarDestinos.UseVisualStyleBackColor = true;
            // 
            // cmbDestinoC
            // 
            this.cmbDestinoC.FormattingEnabled = true;
            this.cmbDestinoC.Location = new System.Drawing.Point(360, 18);
            this.cmbDestinoC.Name = "cmbDestinoC";
            this.cmbDestinoC.Size = new System.Drawing.Size(121, 24);
            this.cmbDestinoC.TabIndex = 3;
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(316, 24);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(46, 16);
            this.lblHasta.TabIndex = 1;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(9, 24);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(51, 16);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryEDDiesenbergM.Properties.Resources._1_gSjqIyW4p3T45OuyYq5_UQ__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmbOrigenC
            // 
            this.cmbOrigenC.FormattingEnabled = true;
            this.cmbOrigenC.Location = new System.Drawing.Point(59, 18);
            this.cmbOrigenC.Name = "cmbOrigenC";
            this.cmbOrigenC.Size = new System.Drawing.Size(121, 24);
            this.cmbOrigenC.TabIndex = 2;
            // 
            // frmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.gbListarViajes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbCargaDatos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmGrafo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones en un Grafo";
            this.Load += new System.EventHandler(this.frmGrafo_Load);
            this.gbCargaDatos.ResumeLayout(false);
            this.gbCargaDatos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbListarViajes.ResumeLayout(false);
            this.gbListarViajes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrafo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbCargaDatos;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbOrigenA;
        private System.Windows.Forms.ComboBox cmbDestinoA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio2;
        private System.Windows.Forms.ComboBox cmbDestinoE;
        private System.Windows.Forms.ComboBox cmbOrigenE;
        private System.Windows.Forms.Button btnBorrarTodo;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.GroupBox gbListarViajes;
        private System.Windows.Forms.ComboBox cmbDestinoC;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DataGridView dgvGrafo;
        private System.Windows.Forms.Button btnVerViajes;
        private System.Windows.Forms.Button btnListarOrigenes;
        private System.Windows.Forms.Button btnListarDestinos;
        private System.Windows.Forms.ComboBox cmbOrigenC;
    }
}