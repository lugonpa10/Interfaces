namespace NuevosComponentes2
{
    partial class EtiquetaAviso
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelTextBox1 = new NuevosComponentes2.LabelTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // labelTextBox1
            // 
            this.labelTextBox1.Location = new System.Drawing.Point(0, 0);
            this.labelTextBox1.Name = "labelTextBox1";
            this.labelTextBox1.Posicion = NuevosComponentes2.EPosicion.IZQUIERDA;
            this.labelTextBox1.Separacion = 0;
            this.labelTextBox1.Size = new System.Drawing.Size(394, 20);
            this.labelTextBox1.TabIndex = 0;
            this.labelTextBox1.TextLbl = "LabelTextBox";
            this.labelTextBox1.TextTxt = "";
            // 
            // EtiquetaAviso
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private LabelTextBox labelTextBox1;
    }
}
