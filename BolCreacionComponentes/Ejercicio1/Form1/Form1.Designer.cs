namespace Form1
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
            this.BtnCambioPos = new System.Windows.Forms.Button();
            this.BtnAumentar = new System.Windows.Forms.Button();
            this.BtnDisminuir = new System.Windows.Forms.Button();
            this.labelTextBox1 = new Ejercicio1.LabelTextBox();
            this.SuspendLayout();
            // 
            // BtnCambioPos
            // 
            this.BtnCambioPos.Location = new System.Drawing.Point(274, 297);
            this.BtnCambioPos.Name = "BtnCambioPos";
            this.BtnCambioPos.Size = new System.Drawing.Size(75, 23);
            this.BtnCambioPos.TabIndex = 1;
            this.BtnCambioPos.Text = "Posicion";
            this.BtnCambioPos.UseVisualStyleBackColor = true;
            this.BtnCambioPos.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnAumentar
            // 
            this.BtnAumentar.Location = new System.Drawing.Point(177, 214);
            this.BtnAumentar.Name = "BtnAumentar";
            this.BtnAumentar.Size = new System.Drawing.Size(75, 23);
            this.BtnAumentar.TabIndex = 2;
            this.BtnAumentar.Text = "Aumentar";
            this.BtnAumentar.UseVisualStyleBackColor = true;
            this.BtnAumentar.Click += new System.EventHandler(this.BtnAumentar_Click);
            this.BtnAumentar.MouseEnter += new System.EventHandler(this.Texto_Botones);
            // 
            // BtnDisminuir
            // 
            this.BtnDisminuir.Location = new System.Drawing.Point(363, 214);
            this.BtnDisminuir.Name = "BtnDisminuir";
            this.BtnDisminuir.Size = new System.Drawing.Size(75, 23);
            this.BtnDisminuir.TabIndex = 3;
            this.BtnDisminuir.Text = "Disminuir";
            this.BtnDisminuir.UseVisualStyleBackColor = true;
            this.BtnDisminuir.Click += new System.EventHandler(this.BtnDisminuir_Click);
            this.BtnDisminuir.MouseEnter += new System.EventHandler(this.Texto_Botones);
            // 
            // labelTextBox1
            // 
            this.labelTextBox1.Location = new System.Drawing.Point(116, 56);
            this.labelTextBox1.Name = "labelTextBox1";
            this.labelTextBox1.Posicion = Ejercicio1.LabelTextBox.EPosicion.IZQUIERDA;
            this.labelTextBox1.PswChr = '\0';
            this.labelTextBox1.Separacion = 0;
            this.labelTextBox1.Size = new System.Drawing.Size(179, 45);
            this.labelTextBox1.TabIndex = 0;
            this.labelTextBox1.TextLbl = "label1";
            this.labelTextBox1.TextTxt = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDisminuir);
            this.Controls.Add(this.BtnAumentar);
            this.Controls.Add(this.BtnCambioPos);
            this.Controls.Add(this.labelTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Ejercicio1.LabelTextBox labelTextBox1;
        private System.Windows.Forms.Button BtnCambioPos;
        private System.Windows.Forms.Button BtnAumentar;
        private System.Windows.Forms.Button BtnDisminuir;
    }
}

