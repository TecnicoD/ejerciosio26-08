namespace ejerciosio26_08
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RdbCamisa = new System.Windows.Forms.RadioButton();
            this.RdbPantalon = new System.Windows.Forms.RadioButton();
            this.RdbRemera = new System.Windows.Forms.RadioButton();
            this.LstVendedor1 = new System.Windows.Forms.ListBox();
            this.BtnCargar = new System.Windows.Forms.Button();
            this.ChkBoxLentes = new System.Windows.Forms.CheckBox();
            this.ChkBoxAros = new System.Windows.Forms.CheckBox();
            this.ChkBoxGorra = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RdbAmarillo = new System.Windows.Forms.RadioButton();
            this.RdbVerde = new System.Windows.Forms.RadioButton();
            this.RdbAzul = new System.Windows.Forms.RadioButton();
            this.RdbRojo = new System.Windows.Forms.RadioButton();
            this.LstVendedor2 = new System.Windows.Forms.ListBox();
            this.LstBoxVendedor3 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnBorrar3 = new System.Windows.Forms.Button();
            this.BtnBorrar2 = new System.Windows.Forms.Button();
            this.BtnBorar1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "VENDEDOR-1",
            "VENDEDOR-2",
            "VENDEDOR-3"});
            this.comboBox1.Location = new System.Drawing.Point(162, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RdbCamisa
            // 
            this.RdbCamisa.AutoSize = true;
            this.RdbCamisa.Location = new System.Drawing.Point(0, 26);
            this.RdbCamisa.Name = "RdbCamisa";
            this.RdbCamisa.Size = new System.Drawing.Size(65, 17);
            this.RdbCamisa.TabIndex = 1;
            this.RdbCamisa.TabStop = true;
            this.RdbCamisa.Text = "CAMISA";
            this.RdbCamisa.UseVisualStyleBackColor = true;
            this.RdbCamisa.CheckedChanged += new System.EventHandler(this.RdbCamisa_CheckedChanged);
            // 
            // RdbPantalon
            // 
            this.RdbPantalon.AutoSize = true;
            this.RdbPantalon.Location = new System.Drawing.Point(0, 49);
            this.RdbPantalon.Name = "RdbPantalon";
            this.RdbPantalon.Size = new System.Drawing.Size(83, 17);
            this.RdbPantalon.TabIndex = 2;
            this.RdbPantalon.TabStop = true;
            this.RdbPantalon.Text = "PANTALON";
            this.RdbPantalon.UseVisualStyleBackColor = true;
            this.RdbPantalon.CheckedChanged += new System.EventHandler(this.RdbPantalon_CheckedChanged);
            // 
            // RdbRemera
            // 
            this.RdbRemera.AutoSize = true;
            this.RdbRemera.Location = new System.Drawing.Point(0, 72);
            this.RdbRemera.Name = "RdbRemera";
            this.RdbRemera.Size = new System.Drawing.Size(71, 17);
            this.RdbRemera.TabIndex = 3;
            this.RdbRemera.TabStop = true;
            this.RdbRemera.Text = "REMERA";
            this.RdbRemera.UseVisualStyleBackColor = true;
            this.RdbRemera.CheckedChanged += new System.EventHandler(this.RdbRemera_CheckedChanged);
            // 
            // LstVendedor1
            // 
            this.LstVendedor1.FormattingEnabled = true;
            this.LstVendedor1.Location = new System.Drawing.Point(88, 305);
            this.LstVendedor1.Name = "LstVendedor1";
            this.LstVendedor1.Size = new System.Drawing.Size(91, 121);
            this.LstVendedor1.TabIndex = 4;
            // 
            // BtnCargar
            // 
            this.BtnCargar.Location = new System.Drawing.Point(80, 211);
            this.BtnCargar.Name = "BtnCargar";
            this.BtnCargar.Size = new System.Drawing.Size(344, 70);
            this.BtnCargar.TabIndex = 5;
            this.BtnCargar.Text = "CARGAR";
            this.BtnCargar.UseVisualStyleBackColor = true;
            this.BtnCargar.Click += new System.EventHandler(this.BtnCargar_Click);
            // 
            // ChkBoxLentes
            // 
            this.ChkBoxLentes.AutoSize = true;
            this.ChkBoxLentes.Location = new System.Drawing.Point(6, 26);
            this.ChkBoxLentes.Name = "ChkBoxLentes";
            this.ChkBoxLentes.Size = new System.Drawing.Size(68, 17);
            this.ChkBoxLentes.TabIndex = 6;
            this.ChkBoxLentes.Text = "LENTES";
            this.ChkBoxLentes.UseVisualStyleBackColor = true;
            this.ChkBoxLentes.CheckedChanged += new System.EventHandler(this.ChkBoxLentes_CheckedChanged);
            // 
            // ChkBoxAros
            // 
            this.ChkBoxAros.AutoSize = true;
            this.ChkBoxAros.Location = new System.Drawing.Point(6, 49);
            this.ChkBoxAros.Name = "ChkBoxAros";
            this.ChkBoxAros.Size = new System.Drawing.Size(56, 17);
            this.ChkBoxAros.TabIndex = 7;
            this.ChkBoxAros.Text = "AROS";
            this.ChkBoxAros.UseVisualStyleBackColor = true;
            this.ChkBoxAros.CheckedChanged += new System.EventHandler(this.ChkBoxAros_CheckedChanged);
            // 
            // ChkBoxGorra
            // 
            this.ChkBoxGorra.AutoSize = true;
            this.ChkBoxGorra.Location = new System.Drawing.Point(6, 73);
            this.ChkBoxGorra.Name = "ChkBoxGorra";
            this.ChkBoxGorra.Size = new System.Drawing.Size(65, 17);
            this.ChkBoxGorra.TabIndex = 8;
            this.ChkBoxGorra.Text = "GORRA";
            this.ChkBoxGorra.UseVisualStyleBackColor = true;
            this.ChkBoxGorra.CheckedChanged += new System.EventHandler(this.ChkBoxGorra_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbRemera);
            this.groupBox1.Controls.Add(this.RdbPantalon);
            this.groupBox1.Controls.Add(this.RdbCamisa);
            this.groupBox1.Location = new System.Drawing.Point(99, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(87, 95);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRENDA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RdbRojo);
            this.groupBox2.Controls.Add(this.RdbAzul);
            this.groupBox2.Controls.Add(this.RdbVerde);
            this.groupBox2.Controls.Add(this.RdbAmarillo);
            this.groupBox2.Location = new System.Drawing.Point(203, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(92, 141);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COLOR";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ChkBoxAros);
            this.groupBox3.Controls.Add(this.ChkBoxLentes);
            this.groupBox3.Controls.Add(this.ChkBoxGorra);
            this.groupBox3.Location = new System.Drawing.Point(328, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(96, 95);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ACCESORIOS";
            // 
            // RdbAmarillo
            // 
            this.RdbAmarillo.AutoSize = true;
            this.RdbAmarillo.Location = new System.Drawing.Point(6, 19);
            this.RdbAmarillo.Name = "RdbAmarillo";
            this.RdbAmarillo.Size = new System.Drawing.Size(79, 17);
            this.RdbAmarillo.TabIndex = 4;
            this.RdbAmarillo.TabStop = true;
            this.RdbAmarillo.Text = "AMARILLO";
            this.RdbAmarillo.UseVisualStyleBackColor = true;
            this.RdbAmarillo.CheckedChanged += new System.EventHandler(this.RdbAmarillo_CheckedChanged);
            // 
            // RdbVerde
            // 
            this.RdbVerde.AutoSize = true;
            this.RdbVerde.Location = new System.Drawing.Point(0, 48);
            this.RdbVerde.Name = "RdbVerde";
            this.RdbVerde.Size = new System.Drawing.Size(62, 17);
            this.RdbVerde.TabIndex = 5;
            this.RdbVerde.TabStop = true;
            this.RdbVerde.Text = "VERDE";
            this.RdbVerde.UseVisualStyleBackColor = true;
            this.RdbVerde.CheckedChanged += new System.EventHandler(this.RdbVerde_CheckedChanged);
            // 
            // RdbAzul
            // 
            this.RdbAzul.AutoSize = true;
            this.RdbAzul.Location = new System.Drawing.Point(1, 78);
            this.RdbAzul.Name = "RdbAzul";
            this.RdbAzul.Size = new System.Drawing.Size(53, 17);
            this.RdbAzul.TabIndex = 6;
            this.RdbAzul.TabStop = true;
            this.RdbAzul.Text = "AZUL";
            this.RdbAzul.UseVisualStyleBackColor = true;
            this.RdbAzul.CheckedChanged += new System.EventHandler(this.RdbAzul_CheckedChanged);
            // 
            // RdbRojo
            // 
            this.RdbRojo.AutoSize = true;
            this.RdbRojo.Location = new System.Drawing.Point(6, 101);
            this.RdbRojo.Name = "RdbRojo";
            this.RdbRojo.Size = new System.Drawing.Size(54, 17);
            this.RdbRojo.TabIndex = 7;
            this.RdbRojo.TabStop = true;
            this.RdbRojo.Text = "ROJO";
            this.RdbRojo.UseVisualStyleBackColor = true;
            this.RdbRojo.CheckedChanged += new System.EventHandler(this.RdbRojo_CheckedChanged);
            // 
            // LstVendedor2
            // 
            this.LstVendedor2.FormattingEnabled = true;
            this.LstVendedor2.Location = new System.Drawing.Point(202, 305);
            this.LstVendedor2.Name = "LstVendedor2";
            this.LstVendedor2.Size = new System.Drawing.Size(86, 121);
            this.LstVendedor2.TabIndex = 12;
            // 
            // LstBoxVendedor3
            // 
            this.LstBoxVendedor3.FormattingEnabled = true;
            this.LstBoxVendedor3.Location = new System.Drawing.Point(314, 305);
            this.LstBoxVendedor3.Name = "LstBoxVendedor3";
            this.LstBoxVendedor3.Size = new System.Drawing.Size(86, 121);
            this.LstBoxVendedor3.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "VENDEDOR:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "VENDEDOR 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "VENDEDOR 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "VENDEDOR-3";
            // 
            // BtnBorrar3
            // 
            this.BtnBorrar3.Location = new System.Drawing.Point(314, 443);
            this.BtnBorrar3.Name = "BtnBorrar3";
            this.BtnBorrar3.Size = new System.Drawing.Size(88, 70);
            this.BtnBorrar3.TabIndex = 18;
            this.BtnBorrar3.Text = "LIMPIAR";
            this.BtnBorrar3.UseVisualStyleBackColor = true;
            this.BtnBorrar3.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnBorrar2
            // 
            this.BtnBorrar2.Location = new System.Drawing.Point(203, 443);
            this.BtnBorrar2.Name = "BtnBorrar2";
            this.BtnBorrar2.Size = new System.Drawing.Size(88, 70);
            this.BtnBorrar2.TabIndex = 19;
            this.BtnBorrar2.Text = "LIMPIAR";
            this.BtnBorrar2.UseVisualStyleBackColor = true;
            this.BtnBorrar2.Click += new System.EventHandler(this.BtnBorrar2_Click);
            // 
            // BtnBorar1
            // 
            this.BtnBorar1.Location = new System.Drawing.Point(91, 443);
            this.BtnBorar1.Name = "BtnBorar1";
            this.BtnBorar1.Size = new System.Drawing.Size(88, 70);
            this.BtnBorar1.TabIndex = 20;
            this.BtnBorar1.Text = "LIMPIAR";
            this.BtnBorar1.UseVisualStyleBackColor = true;
            this.BtnBorar1.Click += new System.EventHandler(this.BtnBorar1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 561);
            this.Controls.Add(this.BtnBorar1);
            this.Controls.Add(this.BtnBorrar2);
            this.Controls.Add(this.BtnBorrar3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LstBoxVendedor3);
            this.Controls.Add(this.LstVendedor2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCargar);
            this.Controls.Add(this.LstVendedor1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton RdbCamisa;
        private System.Windows.Forms.RadioButton RdbPantalon;
        private System.Windows.Forms.RadioButton RdbRemera;
        private System.Windows.Forms.ListBox LstVendedor1;
        private System.Windows.Forms.Button BtnCargar;
        private System.Windows.Forms.CheckBox ChkBoxLentes;
        private System.Windows.Forms.CheckBox ChkBoxAros;
        private System.Windows.Forms.CheckBox ChkBoxGorra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton RdbRojo;
        private System.Windows.Forms.RadioButton RdbAzul;
        private System.Windows.Forms.RadioButton RdbVerde;
        private System.Windows.Forms.RadioButton RdbAmarillo;
        private System.Windows.Forms.ListBox LstVendedor2;
        private System.Windows.Forms.ListBox LstBoxVendedor3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnBorrar3;
        private System.Windows.Forms.Button BtnBorrar2;
        private System.Windows.Forms.Button BtnBorar1;
    }
}

