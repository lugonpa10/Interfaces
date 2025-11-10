using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form2 : Form
    {
        public Form2(string rutaArchivo)
        {
            InitializeComponent();

            this.pictureBox1.Image = Image.FromFile(rutaArchivo);
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

      

        private void deformarImagenToolStripMenuItem1_Click(object sender, EventArgs e)
        {

          pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void noDeformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode=PictureBoxSizeMode.Zoom;
        }
    }
}
