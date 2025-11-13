namespace Ejercicio3
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deformarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deformarImagenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.noDeformacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deformarImagenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 26);
            // 
            // deformarImagenToolStripMenuItem
            // 
            this.deformarImagenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deformarImagenToolStripMenuItem1,
            this.noDeformacionToolStripMenuItem});
            this.deformarImagenToolStripMenuItem.Name = "deformarImagenToolStripMenuItem";
            this.deformarImagenToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.deformarImagenToolStripMenuItem.Text = "Imagen";
            // 
            // deformarImagenToolStripMenuItem1
            // 
            this.deformarImagenToolStripMenuItem1.Name = "deformarImagenToolStripMenuItem1";
            this.deformarImagenToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.deformarImagenToolStripMenuItem1.Text = "Ajuste Perfecto";
            this.deformarImagenToolStripMenuItem1.Click += new System.EventHandler(this.deformarImagenToolStripMenuItem1_Click);
            // 
            // noDeformacionToolStripMenuItem
            // 
            this.noDeformacionToolStripMenuItem.Name = "noDeformacionToolStripMenuItem";
            this.noDeformacionToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.noDeformacionToolStripMenuItem.Text = "No deformacion";
            this.noDeformacionToolStripMenuItem.Click += new System.EventHandler(this.noDeformacionToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deformarImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deformarImagenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem noDeformacionToolStripMenuItem;
    }
}