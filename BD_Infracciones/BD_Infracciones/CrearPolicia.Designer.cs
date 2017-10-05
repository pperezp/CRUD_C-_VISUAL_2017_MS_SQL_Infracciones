namespace BD_Infracciones {
    partial class CrearPolicia {
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.opMujer = new System.Windows.Forms.RadioButton();
            this.opHombre = new System.Windows.Forms.RadioButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrarPolicia = new System.Windows.Forms.Button();
            this.gridPolicia = new System.Windows.Forms.DataGridView();
            this.txtBuscarPolicia = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPolicia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.opMujer);
            this.groupBox1.Controls.Add(this.opHombre);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRut);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Policia";
            // 
            // opMujer
            // 
            this.opMujer.AutoSize = true;
            this.opMujer.Location = new System.Drawing.Point(96, 125);
            this.opMujer.Name = "opMujer";
            this.opMujer.Size = new System.Drawing.Size(51, 17);
            this.opMujer.TabIndex = 5;
            this.opMujer.TabStop = true;
            this.opMujer.Text = "Mujer";
            this.opMujer.UseVisualStyleBackColor = true;
            // 
            // opHombre
            // 
            this.opHombre.AutoSize = true;
            this.opHombre.Location = new System.Drawing.Point(28, 125);
            this.opHombre.Name = "opHombre";
            this.opHombre.Size = new System.Drawing.Size(62, 17);
            this.opHombre.TabIndex = 4;
            this.opHombre.TabStop = true;
            this.opHombre.Text = "Hombre";
            this.opHombre.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(28, 99);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(167, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(28, 48);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(167, 20);
            this.txtRut.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut:";
            // 
            // btnRegistrarPolicia
            // 
            this.btnRegistrarPolicia.Location = new System.Drawing.Point(114, 185);
            this.btnRegistrarPolicia.Name = "btnRegistrarPolicia";
            this.btnRegistrarPolicia.Size = new System.Drawing.Size(123, 23);
            this.btnRegistrarPolicia.TabIndex = 1;
            this.btnRegistrarPolicia.Text = "Registrar Policia";
            this.btnRegistrarPolicia.UseVisualStyleBackColor = true;
            this.btnRegistrarPolicia.Click += new System.EventHandler(this.btnRegistrarPolicia_Click);
            // 
            // gridPolicia
            // 
            this.gridPolicia.AllowUserToAddRows = false;
            this.gridPolicia.AllowUserToDeleteRows = false;
            this.gridPolicia.AllowUserToOrderColumns = true;
            this.gridPolicia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPolicia.Location = new System.Drawing.Point(243, 38);
            this.gridPolicia.Name = "gridPolicia";
            this.gridPolicia.ReadOnly = true;
            this.gridPolicia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPolicia.Size = new System.Drawing.Size(520, 170);
            this.gridPolicia.TabIndex = 2;
            // 
            // txtBuscarPolicia
            // 
            this.txtBuscarPolicia.Location = new System.Drawing.Point(243, 12);
            this.txtBuscarPolicia.Name = "txtBuscarPolicia";
            this.txtBuscarPolicia.Size = new System.Drawing.Size(520, 20);
            this.txtBuscarPolicia.TabIndex = 3;
            this.txtBuscarPolicia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarPolicia_keyup);
            // 
            // CrearPolicia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 218);
            this.Controls.Add(this.txtBuscarPolicia);
            this.Controls.Add(this.gridPolicia);
            this.Controls.Add(this.btnRegistrarPolicia);
            this.Controls.Add(this.groupBox1);
            this.Name = "CrearPolicia";
            this.Text = "Crear Policia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPolicia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton opMujer;
        private System.Windows.Forms.RadioButton opHombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrarPolicia;
        private System.Windows.Forms.DataGridView gridPolicia;
        private System.Windows.Forms.TextBox txtBuscarPolicia;
    }
}