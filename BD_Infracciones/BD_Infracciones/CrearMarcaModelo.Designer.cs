namespace BD_Infracciones {
    partial class CrearMarcaModelo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnRegistrarMarca = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.txtNombreModelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarModelo = new System.Windows.Forms.Button();
            this.gridMarca = new System.Windows.Forms.DataGridView();
            this.gridModelo = new System.Windows.Forms.DataGridView();
            this.txtBuscarMarca = new System.Windows.Forms.TextBox();
            this.txtBuscarModelo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridModelo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrarMarca
            // 
            this.btnRegistrarMarca.Location = new System.Drawing.Point(89, 117);
            this.btnRegistrarMarca.Name = "btnRegistrarMarca";
            this.btnRegistrarMarca.Size = new System.Drawing.Size(123, 23);
            this.btnRegistrarMarca.TabIndex = 5;
            this.btnRegistrarMarca.Text = "Registrar Marca";
            this.btnRegistrarMarca.UseVisualStyleBackColor = true;
            this.btnRegistrarMarca.Click += new System.EventHandler(this.btnRegistrarMarca_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 99);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(26, 48);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(144, 20);
            this.txtMarca.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboMarca);
            this.groupBox2.Controls.Add(this.txtNombreModelo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 147);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Marca:";
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(26, 92);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(141, 21);
            this.cboMarca.TabIndex = 2;
            // 
            // txtNombreModelo
            // 
            this.txtNombreModelo.Location = new System.Drawing.Point(26, 49);
            this.txtNombreModelo.Name = "txtNombreModelo";
            this.txtNombreModelo.Size = new System.Drawing.Size(144, 20);
            this.txtNombreModelo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // btnRegistrarModelo
            // 
            this.btnRegistrarModelo.Location = new System.Drawing.Point(89, 339);
            this.btnRegistrarModelo.Name = "btnRegistrarModelo";
            this.btnRegistrarModelo.Size = new System.Drawing.Size(122, 23);
            this.btnRegistrarModelo.TabIndex = 7;
            this.btnRegistrarModelo.Text = "Registrar Modelo";
            this.btnRegistrarModelo.UseVisualStyleBackColor = true;
            // 
            // gridMarca
            // 
            this.gridMarca.AllowUserToAddRows = false;
            this.gridMarca.AllowUserToDeleteRows = false;
            this.gridMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMarca.Location = new System.Drawing.Point(218, 44);
            this.gridMarca.Name = "gridMarca";
            this.gridMarca.ReadOnly = true;
            this.gridMarca.Size = new System.Drawing.Size(337, 96);
            this.gridMarca.TabIndex = 8;
            // 
            // gridModelo
            // 
            this.gridModelo.AllowUserToAddRows = false;
            this.gridModelo.AllowUserToDeleteRows = false;
            this.gridModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridModelo.Location = new System.Drawing.Point(219, 211);
            this.gridModelo.Name = "gridModelo";
            this.gridModelo.ReadOnly = true;
            this.gridModelo.Size = new System.Drawing.Size(336, 156);
            this.gridModelo.TabIndex = 9;
            // 
            // txtBuscarMarca
            // 
            this.txtBuscarMarca.Location = new System.Drawing.Point(219, 18);
            this.txtBuscarMarca.Name = "txtBuscarMarca";
            this.txtBuscarMarca.Size = new System.Drawing.Size(336, 20);
            this.txtBuscarMarca.TabIndex = 10;
            // 
            // txtBuscarModelo
            // 
            this.txtBuscarModelo.Location = new System.Drawing.Point(218, 185);
            this.txtBuscarModelo.Name = "txtBuscarModelo";
            this.txtBuscarModelo.Size = new System.Drawing.Size(336, 20);
            this.txtBuscarModelo.TabIndex = 11;
            // 
            // CrearMarcaModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 377);
            this.Controls.Add(this.txtBuscarModelo);
            this.Controls.Add(this.txtBuscarMarca);
            this.Controls.Add(this.gridModelo);
            this.Controls.Add(this.gridMarca);
            this.Controls.Add(this.btnRegistrarModelo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnRegistrarMarca);
            this.Controls.Add(this.groupBox1);
            this.Name = "CrearMarcaModelo";
            this.Text = "CrearMarcaModelo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridModelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegistrarMarca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.TextBox txtNombreModelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarModelo;
        private System.Windows.Forms.DataGridView gridMarca;
        private System.Windows.Forms.DataGridView gridModelo;
        private System.Windows.Forms.TextBox txtBuscarMarca;
        private System.Windows.Forms.TextBox txtBuscarModelo;
    }
}