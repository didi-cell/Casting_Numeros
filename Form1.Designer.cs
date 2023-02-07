namespace P4._2_CastingNumeros_DL
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.entero = new System.Windows.Forms.TextBox();
            this.real = new System.Windows.Forms.TextBox();
            this.doble = new System.Windows.Forms.TextBox();
            this.mitad = new System.Windows.Forms.TextBox();
            this.Bentero = new System.Windows.Forms.Button();
            this.Breal = new System.Windows.Forms.Button();
            this.Bsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dime un número entero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dime un número real:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "El doble del número es:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "La mitad del número es:";
            // 
            // entero
            // 
            this.entero.Location = new System.Drawing.Point(211, 35);
            this.entero.Name = "entero";
            this.entero.Size = new System.Drawing.Size(100, 22);
            this.entero.TabIndex = 4;
            this.entero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // real
            // 
            this.real.Location = new System.Drawing.Point(211, 75);
            this.real.Name = "real";
            this.real.Size = new System.Drawing.Size(100, 22);
            this.real.TabIndex = 5;
            this.real.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // doble
            // 
            this.doble.Location = new System.Drawing.Point(211, 115);
            this.doble.Name = "doble";
            this.doble.Size = new System.Drawing.Size(100, 22);
            this.doble.TabIndex = 6;
            this.doble.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mitad
            // 
            this.mitad.Location = new System.Drawing.Point(211, 158);
            this.mitad.Name = "mitad";
            this.mitad.Size = new System.Drawing.Size(100, 22);
            this.mitad.TabIndex = 7;
            this.mitad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Bentero
            // 
            this.Bentero.Location = new System.Drawing.Point(331, 34);
            this.Bentero.Name = "Bentero";
            this.Bentero.Size = new System.Drawing.Size(75, 23);
            this.Bentero.TabIndex = 8;
            this.Bentero.Text = "Convertir";
            this.Bentero.UseVisualStyleBackColor = true;
            this.Bentero.Click += new System.EventHandler(this.Bentero_Click);
            // 
            // Breal
            // 
            this.Breal.Location = new System.Drawing.Point(331, 74);
            this.Breal.Name = "Breal";
            this.Breal.Size = new System.Drawing.Size(75, 23);
            this.Breal.TabIndex = 9;
            this.Breal.Text = "Convertir";
            this.Breal.UseVisualStyleBackColor = true;
            this.Breal.Click += new System.EventHandler(this.Breal_Click);
            // 
            // Bsalir
            // 
            this.Bsalir.Location = new System.Drawing.Point(331, 177);
            this.Bsalir.Name = "Bsalir";
            this.Bsalir.Size = new System.Drawing.Size(75, 23);
            this.Bsalir.TabIndex = 10;
            this.Bsalir.Text = "Salir";
            this.Bsalir.UseVisualStyleBackColor = true;
            this.Bsalir.Click += new System.EventHandler(this.Bsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 232);
            this.Controls.Add(this.Bsalir);
            this.Controls.Add(this.Breal);
            this.Controls.Add(this.Bentero);
            this.Controls.Add(this.mitad);
            this.Controls.Add(this.doble);
            this.Controls.Add(this.real);
            this.Controls.Add(this.entero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Trabajando con cadenas y números";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox entero;
        private System.Windows.Forms.TextBox real;
        private System.Windows.Forms.TextBox doble;
        private System.Windows.Forms.TextBox mitad;
        private System.Windows.Forms.Button Bentero;
        private System.Windows.Forms.Button Breal;
        private System.Windows.Forms.Button Bsalir;
    }
}

