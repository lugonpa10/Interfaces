using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
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
        private void BtnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!listBox1.Items.Contains(textBox1.Text))
                {
                    listBox1.Items.Add(textBox1.Text);
                }

            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Argumento invalido",
                    "Error caracteres",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (System.Exception)
            {
                MessageBox.Show("Error inesperado",
                    "Error sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


        }

       

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {

                


            }
            if (radioButton2.Checked)
            {

                listBox2.Items.Clear();
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton1.Text = "Elimina de 1";

            }
            else
            {
                radioButton1.Text = "radiobutton 1";
            }


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton2.Text = "Elimina de 2";

            }
            else
            {
                radioButton2.Text = "radiobutton 2";
            }
        }

        private void BtnTraspasar_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                foreach (ListBox listbox in listBox1.Items)
                {

                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                radioButton3.Text = "Traspaso de 1->2";
            }
            else
            {
                radioButton3.Text = "radiobutton 3";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                radioButton4.Text = "Traspaso de 2->1";
            }
            else
            {
                radioButton4.Text = "radiobutton 4";
            }
        }
    }
}
