namespace BD_Infracciones {
    partial class CrearAutomovil {
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
            this.txtBuscarAutomovil = new System.Windows.Forms.TextBox();
            this.gridAutomoviles = new System.Windows.Forms.DataGridView();
            this.btnRegistrarAutomovil = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboModelo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridAutomoviles)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscarAutomovil
            // 
            this.txtBuscarAutomovil.Location = new System.Drawing.Point(218, 12);
            this.txtBuscarAutomovil.Name = "txtBuscarAutomovil";
            this.txtBuscarAutomovil.Size = new System.Drawing.Size(336, 20);
            this.txtBuscarAutomovil.TabIndex = 15;
            // 
            // gridAutomoviles
            // 
            this.gridAutomoviles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAutomoviles.Location = new System.Drawing.Point(218, 38);
            this.gridAutomoviles.Name = "gridAutomoviles";
            this.gridAutomoviles.Size = new System.Drawing.Size(336, 195);
            this.gridAutomoviles.TabIndex = 14;
            // 
            // btnRegistrarAutomovil
            // 
            this.btnRegistrarAutomovil.Location = new System.Drawing.Point(90, 210);
            this.btnRegistrarAutomovil.Name = "btnRegistrarAutomovil";
            this.btnRegistrarAutomovil.Size = new System.Drawing.Size(122, 23);
            this.btnRegistrarAutomovil.TabIndex = 13;
            this.btnRegistrarAutomovil.Text = "Registrar Automovil";
            this.btnRegistrarAutomovil.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboModelo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboMarca);
            this.groupBox2.Controls.Add(this.txtPatente);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 192);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Automovil";
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
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(29, 92);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(141, 21);
            this.cboMarca.TabIndex = 2;
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(29, 48);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(144, 20);
            this.txtPatente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Modelo:";
            // 
            // cboModelo
            // 
            this.cboModelo.FormattingEnabled = true;
            this.cboModelo.Location = new System.Drawing.Point(29, 142);
            this.cboModelo.Name = "cboModelo";
            this.cboModelo.Size = new System.Drawing.Size(141, 21);
            this.cboModelo.TabIndex = 4;
            // 
            // CrearAutomovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 247);
            this.Controls.Add(this.txtBuscarAutomovil);
            this.Controls.Add(this.gridAutomoviles);
            this.Controls.Add(this.btnRegistrarAutomovil);
            this.Controls.Add(this.groupBox2);
            this.Name = "CrearAutomovil";
            this.Text = "CrearAutomovil";
            ((System.ComponentModel.ISupportInitialize)(this.gridAutomoviles)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarAutomovil;
        private System.Windows.Forms.DataGridView gridAutomoviles;
        private System.Windows.Forms.Button btnRegistrarAutomovil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboModelo;
    }
}