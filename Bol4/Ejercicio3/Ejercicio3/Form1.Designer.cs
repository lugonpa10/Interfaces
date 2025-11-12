namespace Ejercicio3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNuevaImg = new System.Windows.Forms.Button();
            this.checkModal = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnNuevaImg
            // 
            this.btnNuevaImg.Location = new System.Drawing.Point(226, 282);
            this.btnNuevaImg.Name = "btnNuevaImg";
            this.btnNuevaImg.Size = new System.Drawing.Size(146, 23);
            this.btnNuevaImg.TabIndex = 0;
            this.btnNuevaImg.Text = "Nueva Imagen";
            this.btnNuevaImg.UseVisualStyleBackColor = true;
            this.btnNuevaImg.Click += new System.EventHandler(this.btnNuevaImg_Click);
            // 
            // checkModal
            // 
            this.checkModal.AutoSize = true;
            this.checkModal.Location = new System.Drawing.Point(458, 288);
            this.checkModal.Name = "checkModal";
            this.checkModal.Size = new System.Drawing.Size(55, 17);
            this.checkModal.TabIndex = 1;
            this.checkModal.Text = "Modal\r\n";
            this.checkModal.UseVisualStyleBackColor = true;
            this.checkModal.CheckedChanged += new System.EventHandler(this.checkModal_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkModal);
            this.Controls.Add(this.btnNuevaImg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevaImg;
        private System.Windows.Forms.CheckBox checkModal;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.Timer timer1;
    }
}

