namespace Form2
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
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.btnGuarda = new System.Windows.Forms.Button();
            this.btnElemento = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lstDatos2 = new System.Windows.Forms.ListBox();
            this.btnCopia = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnInserta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.Items.AddRange(new object[] {
            "Valeria",
            "Carlita",
            "Mariana"});
            this.lstDatos.Location = new System.Drawing.Point(41, 43);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(127, 160);
            this.lstDatos.TabIndex = 0;
            this.lstDatos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstDatos_MouseDoubleClick);
            // 
            // btnGuarda
            // 
            this.btnGuarda.Location = new System.Drawing.Point(203, 43);
            this.btnGuarda.Name = "btnGuarda";
            this.btnGuarda.Size = new System.Drawing.Size(75, 23);
            this.btnGuarda.TabIndex = 1;
            this.btnGuarda.Text = "Guardar";
            this.btnGuarda.UseVisualStyleBackColor = true;
            this.btnGuarda.Click += new System.EventHandler(this.btnGuarda_Click);
            // 
            // btnElemento
            // 
            this.btnElemento.Location = new System.Drawing.Point(203, 88);
            this.btnElemento.Name = "btnElemento";
            this.btnElemento.Size = new System.Drawing.Size(75, 23);
            this.btnElemento.TabIndex = 2;
            this.btnElemento.Text = "Elemento";
            this.btnElemento.UseVisualStyleBackColor = true;
            this.btnElemento.Click += new System.EventHandler(this.btnElemento_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(203, 126);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lstDatos2
            // 
            this.lstDatos2.FormattingEnabled = true;
            this.lstDatos2.Location = new System.Drawing.Point(41, 209);
            this.lstDatos2.Name = "lstDatos2";
            this.lstDatos2.Size = new System.Drawing.Size(127, 199);
            this.lstDatos2.TabIndex = 4;
            // 
            // btnCopia
            // 
            this.btnCopia.Location = new System.Drawing.Point(203, 237);
            this.btnCopia.Name = "btnCopia";
            this.btnCopia.Size = new System.Drawing.Size(75, 23);
            this.btnCopia.TabIndex = 5;
            this.btnCopia.Text = "Copiar";
            this.btnCopia.UseVisualStyleBackColor = true;
            this.btnCopia.Click += new System.EventHandler(this.btnCopia_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.comboBox1.Location = new System.Drawing.Point(331, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // btnInserta
            // 
            this.btnInserta.Location = new System.Drawing.Point(536, 43);
            this.btnInserta.Name = "btnInserta";
            this.btnInserta.Size = new System.Drawing.Size(75, 23);
            this.btnInserta.TabIndex = 7;
            this.btnInserta.Text = "Insertar";
            this.btnInserta.UseVisualStyleBackColor = true;
            this.btnInserta.Click += new System.EventHandler(this.btnInserta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 443);
            this.Controls.Add(this.btnInserta);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnCopia);
            this.Controls.Add(this.lstDatos2);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnElemento);
            this.Controls.Add(this.btnGuarda);
            this.Controls.Add(this.lstDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.Button btnGuarda;
        private System.Windows.Forms.Button btnElemento;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ListBox lstDatos2;
        private System.Windows.Forms.Button btnCopia;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnInserta;
    }
}

