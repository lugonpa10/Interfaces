using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Mi Aplicación",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question)
       == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int color1;
            bool flag = int.TryParse(textBox1.Text, out color1);
            if (flag)
            {
                if (color1 >= 0 && color1 <= 255)
                {

                }
                else
                {
                    MessageBox.Show("El valor debe estar entre 0 y 255", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }


        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int color2;
            bool flag = int.TryParse(textBox2.Text, out color2);
            if (flag)
            {
                if (color2 >= 0 && color2 <= 255)
                {

                }
                else
                {
                    MessageBox.Show("El valor debe estar entre 0 y 255", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int color3;
            bool flag = int.TryParse(textBox3.Text, out color3);
            if (flag)
            {
                if (color3 >= 0 && color3 <= 255)
                {

                }
                else
                {
                    MessageBox.Show("El valor debe estar entre 0 y 255", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            int color1;
            int color2;
            int color3;
            bool flag = int.TryParse(textBox1.Text, out color1);
            bool flag2 = int.TryParse(textBox2.Text, out color2);
            bool flag3 = int.TryParse(textBox3.Text, out color3);

            this.BackColor = Color.FromArgb(color1, color2, color3);

            Color.FromArgb(color1, color2, color3);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnImagen_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
