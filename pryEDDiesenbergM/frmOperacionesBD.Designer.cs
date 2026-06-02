namespace pryEDDiesenbergM
{
    partial class frmOperacionesBD
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
            this.dgvBD = new System.Windows.Forms.DataGridView();
            this.gbOpProyeccion = new System.Windows.Forms.GroupBox();
            this.btnProySimple = new System.Windows.Forms.Button();
            this.btnMultiatributo = new System.Windows.Forms.Button();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.gbOpSeleccion = new System.Windows.Forms.GroupBox();
            this.btnSeleccionSimple = new System.Windows.Forms.Button();
            this.btnMultiat = new System.Windows.Forms.Button();
            this.btnConvolucion = new System.Windows.Forms.Button();
            this.gbOpAlgebraicas = new System.Windows.Forms.GroupBox();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBD)).BeginInit();
            this.gbOpProyeccion.SuspendLayout();
            this.gbOpSeleccion.SuspendLayout();
            this.gbOpAlgebraicas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBD
            // 
            this.dgvBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBD.Location = new System.Drawing.Point(12, 12);
            this.dgvBD.Name = "dgvBD";
            this.dgvBD.Size = new System.Drawing.Size(776, 276);
            this.dgvBD.TabIndex = 0;
            // 
            // gbOpProyeccion
            // 
            this.gbOpProyeccion.Controls.Add(this.btnProySimple);
            this.gbOpProyeccion.Controls.Add(this.btnMultiatributo);
            this.gbOpProyeccion.Controls.Add(this.btnJuntar);
            this.gbOpProyeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpProyeccion.Location = new System.Drawing.Point(12, 294);
            this.gbOpProyeccion.Name = "gbOpProyeccion";
            this.gbOpProyeccion.Size = new System.Drawing.Size(236, 133);
            this.gbOpProyeccion.TabIndex = 1;
            this.gbOpProyeccion.TabStop = false;
            this.gbOpProyeccion.Text = "Operaciones de Proyección - SELECT";
            // 
            // btnProySimple
            // 
            this.btnProySimple.Location = new System.Drawing.Point(6, 20);
            this.btnProySimple.Name = "btnProySimple";
            this.btnProySimple.Size = new System.Drawing.Size(224, 23);
            this.btnProySimple.TabIndex = 0;
            this.btnProySimple.Text = "Proyección Simple";
            this.btnProySimple.UseVisualStyleBackColor = true;
            // 
            // btnMultiatributo
            // 
            this.btnMultiatributo.Location = new System.Drawing.Point(6, 57);
            this.btnMultiatributo.Name = "btnMultiatributo";
            this.btnMultiatributo.Size = new System.Drawing.Size(224, 23);
            this.btnMultiatributo.TabIndex = 1;
            this.btnMultiatributo.Text = "Proyección multiatributo";
            this.btnMultiatributo.UseVisualStyleBackColor = true;
            this.btnMultiatributo.Click += new System.EventHandler(this.btnMultiatributo_Click);
            // 
            // btnJuntar
            // 
            this.btnJuntar.Location = new System.Drawing.Point(6, 93);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(224, 23);
            this.btnJuntar.TabIndex = 2;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            // 
            // gbOpSeleccion
            // 
            this.gbOpSeleccion.Controls.Add(this.btnSeleccionSimple);
            this.gbOpSeleccion.Controls.Add(this.btnMultiat);
            this.gbOpSeleccion.Controls.Add(this.btnConvolucion);
            this.gbOpSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpSeleccion.Location = new System.Drawing.Point(284, 294);
            this.gbOpSeleccion.Name = "gbOpSeleccion";
            this.gbOpSeleccion.Size = new System.Drawing.Size(236, 133);
            this.gbOpSeleccion.TabIndex = 2;
            this.gbOpSeleccion.TabStop = false;
            this.gbOpSeleccion.Text = "Operaciones de Selección - WHERE";
            // 
            // btnSeleccionSimple
            // 
            this.btnSeleccionSimple.Location = new System.Drawing.Point(6, 20);
            this.btnSeleccionSimple.Name = "btnSeleccionSimple";
            this.btnSeleccionSimple.Size = new System.Drawing.Size(224, 23);
            this.btnSeleccionSimple.TabIndex = 3;
            this.btnSeleccionSimple.Text = "Selección simple";
            this.btnSeleccionSimple.UseVisualStyleBackColor = true;
            // 
            // btnMultiat
            // 
            this.btnMultiat.Location = new System.Drawing.Point(6, 57);
            this.btnMultiat.Name = "btnMultiat";
            this.btnMultiat.Size = new System.Drawing.Size(224, 23);
            this.btnMultiat.TabIndex = 4;
            this.btnMultiat.Text = "Selección multiatributo";
            this.btnMultiat.UseVisualStyleBackColor = true;
            // 
            // btnConvolucion
            // 
            this.btnConvolucion.Location = new System.Drawing.Point(6, 93);
            this.btnConvolucion.Name = "btnConvolucion";
            this.btnConvolucion.Size = new System.Drawing.Size(224, 23);
            this.btnConvolucion.TabIndex = 5;
            this.btnConvolucion.Text = "Selección por convolución";
            this.btnConvolucion.UseVisualStyleBackColor = true;
            // 
            // gbOpAlgebraicas
            // 
            this.gbOpAlgebraicas.Controls.Add(this.btnDiferencia);
            this.gbOpAlgebraicas.Controls.Add(this.btnInterseccion);
            this.gbOpAlgebraicas.Controls.Add(this.btnUnion);
            this.gbOpAlgebraicas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOpAlgebraicas.Location = new System.Drawing.Point(552, 294);
            this.gbOpAlgebraicas.Name = "gbOpAlgebraicas";
            this.gbOpAlgebraicas.Size = new System.Drawing.Size(236, 133);
            this.gbOpAlgebraicas.TabIndex = 3;
            this.gbOpAlgebraicas.TabStop = false;
            this.gbOpAlgebraicas.Text = "Operaciones Algebraicas";
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Location = new System.Drawing.Point(6, 93);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(224, 23);
            this.btnDiferencia.TabIndex = 8;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Location = new System.Drawing.Point(6, 57);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(224, 23);
            this.btnInterseccion.TabIndex = 7;
            this.btnInterseccion.Text = "Intersección";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            // 
            // btnUnion
            // 
            this.btnUnion.Location = new System.Drawing.Point(6, 20);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(224, 23);
            this.btnUnion.TabIndex = 6;
            this.btnUnion.Text = "Unión";
            this.btnUnion.UseVisualStyleBackColor = true;
            // 
            // frmOperacionesBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbOpAlgebraicas);
            this.Controls.Add(this.gbOpSeleccion);
            this.Controls.Add(this.gbOpProyeccion);
            this.Controls.Add(this.dgvBD);
            this.Name = "frmOperacionesBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base de Datos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBD)).EndInit();
            this.gbOpProyeccion.ResumeLayout(false);
            this.gbOpSeleccion.ResumeLayout(false);
            this.gbOpAlgebraicas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBD;
        private System.Windows.Forms.GroupBox gbOpProyeccion;
        private System.Windows.Forms.GroupBox gbOpSeleccion;
        private System.Windows.Forms.GroupBox gbOpAlgebraicas;
        private System.Windows.Forms.Button btnProySimple;
        private System.Windows.Forms.Button btnMultiatributo;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnSeleccionSimple;
        private System.Windows.Forms.Button btnMultiat;
        private System.Windows.Forms.Button btnConvolucion;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button btnUnion;
    }
}