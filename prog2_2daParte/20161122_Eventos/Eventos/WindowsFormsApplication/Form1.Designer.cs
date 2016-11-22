namespace WindowsFormsApplication
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxLado = new System.Windows.Forms.ComboBox();
            this.monedaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonJugar = new System.Windows.Forms.Button();
            this.labelGanar = new System.Windows.Forms.Label();
            this.labelPerder = new System.Windows.Forms.Label();
            this.labelCantGanar = new System.Windows.Forms.Label();
            this.labelCantPerder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.monedaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxLado
            // 
            this.comboBoxLado.FormattingEnabled = true;
            this.comboBoxLado.Location = new System.Drawing.Point(13, 13);
            this.comboBoxLado.Name = "comboBoxLado";
            this.comboBoxLado.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLado.TabIndex = 0;
            // 
            // monedaBindingSource
            // 
            this.monedaBindingSource.DataSource = typeof(ClassLibrary.Moneda);
            // 
            // buttonJugar
            // 
            this.buttonJugar.Location = new System.Drawing.Point(13, 40);
            this.buttonJugar.Name = "buttonJugar";
            this.buttonJugar.Size = new System.Drawing.Size(75, 23);
            this.buttonJugar.TabIndex = 1;
            this.buttonJugar.Text = "JUGAR";
            this.buttonJugar.UseVisualStyleBackColor = true;
            this.buttonJugar.Click += new System.EventHandler(this.buttonJugar_Click);
            // 
            // labelGanar
            // 
            this.labelGanar.AutoSize = true;
            this.labelGanar.Location = new System.Drawing.Point(13, 70);
            this.labelGanar.Name = "labelGanar";
            this.labelGanar.Size = new System.Drawing.Size(53, 13);
            this.labelGanar.TabIndex = 2;
            this.labelGanar.Text = "Ganaste: ";
            // 
            // labelPerder
            // 
            this.labelPerder.AutoSize = true;
            this.labelPerder.Location = new System.Drawing.Point(13, 87);
            this.labelPerder.Name = "labelPerder";
            this.labelPerder.Size = new System.Drawing.Size(51, 13);
            this.labelPerder.TabIndex = 3;
            this.labelPerder.Text = "Perdiste: ";
            // 
            // labelCantGanar
            // 
            this.labelCantGanar.AutoSize = true;
            this.labelCantGanar.Location = new System.Drawing.Point(85, 70);
            this.labelCantGanar.Name = "labelCantGanar";
            this.labelCantGanar.Size = new System.Drawing.Size(13, 13);
            this.labelCantGanar.TabIndex = 4;
            this.labelCantGanar.Text = "0";
            // 
            // labelCantPerder
            // 
            this.labelCantPerder.AutoSize = true;
            this.labelCantPerder.Location = new System.Drawing.Point(85, 87);
            this.labelCantPerder.Name = "labelCantPerder";
            this.labelCantPerder.Size = new System.Drawing.Size(13, 13);
            this.labelCantPerder.TabIndex = 5;
            this.labelCantPerder.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(153, 123);
            this.Controls.Add(this.labelCantPerder);
            this.Controls.Add(this.labelCantGanar);
            this.Controls.Add(this.labelPerder);
            this.Controls.Add(this.labelGanar);
            this.Controls.Add(this.buttonJugar);
            this.Controls.Add(this.comboBoxLado);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.monedaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLado;
        private System.Windows.Forms.BindingSource monedaBindingSource;
        private System.Windows.Forms.Button buttonJugar;
        private System.Windows.Forms.Label labelGanar;
        private System.Windows.Forms.Label labelPerder;
        private System.Windows.Forms.Label labelCantGanar;
        private System.Windows.Forms.Label labelCantPerder;
    }
}

