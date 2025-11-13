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

            
            try
            {
                this.pictureBox1.Image = Image.FromFile(rutaArchivo);

            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("Sin memoria",
                    "Error Memoria",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Error de escritura",
                    "Error Imagen",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("No se ha encontrado la imagen",
                    "Error Imagen",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void deformarImagenToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void noDeformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
