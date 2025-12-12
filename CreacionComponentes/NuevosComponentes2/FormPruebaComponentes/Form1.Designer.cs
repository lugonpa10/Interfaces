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
            this.button1 = new System.Windows.Forms.Button();
            this.etiquetaAviso2 = new NuevosComponentes2.EtiquetaAviso();
            this.etiquetaAviso1 = new NuevosComponentes2.EtiquetaAviso();
            this.labelTextBox2 = new NuevosComponentes2.LabelTextBox();
            this.labelTextBox1 = new NuevosComponentes2.LabelTextBox();
            this.SuspendLayout();
            // 
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
            this.etiquetaAviso2.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.etiquetaAviso2.Color2 = System.Drawing.Color.Cyan;
            this.etiquetaAviso2.Gradiente = true;
            this.etiquetaAviso2.Location = new System.Drawing.Point(146, 49);
            this.etiquetaAviso2.Marca = NuevosComponentes2.EMarca.Nada;
            this.etiquetaAviso2.Name = "etiquetaAviso2";
            this.etiquetaAviso2.Size = new System.Drawing.Size(78, 13);
            this.etiquetaAviso2.TabIndex = 4;
            this.etiquetaAviso2.Text = "etiquetaAviso2";
            // 
            // etiquetaAviso1
            // 
            this.etiquetaAviso1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.etiquetaAviso1.Color1 = System.Drawing.Color.Empty;
            this.etiquetaAviso1.Color2 = System.Drawing.Color.Empty;
            this.etiquetaAviso1.Gradiente = false;
            this.etiquetaAviso1.Location = new System.Drawing.Point(423, 70);
            this.etiquetaAviso1.Marca = NuevosComponentes2.EMarca.Cruz;
            this.etiquetaAviso1.Name = "etiquetaAviso1";
            this.etiquetaAviso1.Size = new System.Drawing.Size(97, 15);
            this.etiquetaAviso1.TabIndex = 3;
            this.etiquetaAviso1.Text = "etiquetaAviso1";
            // 
            // labelTextBox2
            // 
            this.labelTextBox2.Location = new System.Drawing.Point(114, 146);
            this.labelTextBox2.Name = "labelTextBox2";
            this.labelTextBox2.Posicion = NuevosComponentes2.EPosicion.IZQUIERDA;
            this.labelTextBox2.Separacion = 0;
            this.labelTextBox2.Size = new System.Drawing.Size(394, 20);
            this.labelTextBox2.TabIndex = 1;
            this.labelTextBox2.TextLbl = "UserControl1";
            this.labelTextBox2.TextTxt = "";
            // 
            // labelTextBox1
            // 
            this.labelTextBox1.Location = new System.Drawing.Point(177, 294);
            this.labelTextBox1.Name = "labelTextBox1";
            this.labelTextBox1.Posicion = NuevosComponentes2.EPosicion.IZQUIERDA;
            this.labelTextBox1.Separacion = 40;
            this.labelTextBox1.Size = new System.Drawing.Size(310, 20);
            this.labelTextBox1.TabIndex = 0;
            this.labelTextBox1.TextLbl = "label1";
            this.labelTextBox1.TextTxt = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.etiquetaAviso2);
            this.Controls.Add(this.etiquetaAviso1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTextBox2);
            this.Controls.Add(this.labelTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private NuevosComponentes2.LabelTextBox labelTextBox1;
        private NuevosComponentes2.LabelTextBox labelTextBox2;
        private System.Windows.Forms.Button button1;
        private NuevosComponentes2.EtiquetaAviso etiquetaAviso1;
        private NuevosComponentes2.EtiquetaAviso etiquetaAviso2;
    }
}

