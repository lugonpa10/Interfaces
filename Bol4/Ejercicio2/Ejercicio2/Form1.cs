using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            this.Text = "Formulario Ejercicio 2";
            textBox1.Tag = 0;
            textBox2.Tag = 0;
            textBox3.Tag = 0;
            textImg.Tag = "";

            textBox1.Enter += Control_Enter;
            textBox2.Enter += Control_Enter;
            textBox3.Enter += Control_Enter;
            textImg.Enter += Control_Enter;

            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.MouseEnter += Botones_MouseEnter;
                    c.MouseLeave += Botones_MouseLeave;
                }
            }





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

        private bool ValidarColor(out byte r, out byte g, out byte b)
        {
            bool flag = true;
            if (!byte.TryParse(textBox1.Text, out r))
            {
                flag = false;

            }
            if (!byte.TryParse(textBox2.Text, out g))
            {
                flag = false;
            }
            if (!byte.TryParse(textBox3.Text, out b))
            {
                flag = false;
            }

            if (!flag)
            {
                MessageBox.Show("Error entrada de valores", "Error Colores",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flag;


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            if (ValidarColor(out byte r, out byte g, out byte b))
            {

                this.BackColor = Color.FromArgb(r, g, b);

                Color.FromArgb(r, g, b);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    if (c.Tag == null)
                    {
                        c.Text = "";
                    }
                    else
                    {
                        c.Text = c.Tag.ToString();
                    }

                }
            }

            this.pictureBox1.Image = null;

            this.BackColor = Color.Empty;




        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {

                string ruta = textImg.Text;
                pictureBox1.Image = Image.FromFile(ruta);

            }
            catch (IOException)
            {
                MessageBox.Show("No se ha encontrado la imagen", "Error imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void textImg_TextChanged(object sender, EventArgs e)
        {

        }

        private void Control_Enter(object sender, EventArgs e)
        {
            if (sender == textBox1 || sender == textBox2 || sender == textBox3)
            {
                this.AcceptButton = btnColor;
            }
            if (sender == textImg)
            {
                this.AcceptButton = btnImagen;
            }

        }

        private void Botones_MouseEnter(object sender, EventArgs e)
        {


            Button btn = (Button)sender;
            btn.BackColor = Color.Red;



        }
        private void Botones_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Empty;

        }



    }
}
