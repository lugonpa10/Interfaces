namespace FormPruebaComponentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.etiquetaAviso1 = new NuevosComponentes2.EtiquetaAviso();
            this.SuspendLayout();
            // 
<<<<<<< HEAD
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // etiquetaAviso2
            // 
            this.etiquetaAviso2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.etiquetaAviso2.Color1 = System.Drawing.Color.Snow;
            this.etiquetaAviso2.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.etiquetaAviso2.Gradiente = true;
            this.etiquetaAviso2.Location = new System.Drawing.Point(147, 49);
            this.etiquetaAviso2.Marca = NuevosComponentes2.EMarca.Nada;
            this.etiquetaAviso2.Name = "etiquetaAviso2";
            this.etiquetaAviso2.Size = new System.Drawing.Size(78, 13);
            this.etiquetaAviso2.TabIndex = 4;
            this.etiquetaAviso2.Text = "etiquetaAviso2";
            // 
=======
>>>>>>> d9517c23f547a3a51dd1bebea94fd05741cb92d4
            // etiquetaAviso1
            // 
            this.etiquetaAviso1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.etiquetaAviso1.Color1 = System.Drawing.Color.Magenta;
            this.etiquetaAviso1.Color2 = System.Drawing.Color.Blue;
            this.etiquetaAviso1.Gradiente = true;
            this.etiquetaAviso1.ImagenMarca = ((System.Drawing.Image)(resources.GetObject("etiquetaAviso1.ImagenMarca")));
            this.etiquetaAviso1.Location = new System.Drawing.Point(268, 86);
            this.etiquetaAviso1.Marca = NuevosComponentes2.EMarca.Imagen;
            this.etiquetaAviso1.Name = "etiquetaAviso1";
            this.etiquetaAviso1.Size = new System.Drawing.Size(91, 13);
            this.etiquetaAviso1.TabIndex = 0;
            this.etiquetaAviso1.Text = "etiquetaAviso1";
            this.etiquetaAviso1.ClickEnMarca += new System.EventHandler(this.etiquetaAviso1_ClickEnMarca);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.etiquetaAviso1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private NuevosComponentes2.EtiquetaAviso etiquetaAviso1;
    }
}

