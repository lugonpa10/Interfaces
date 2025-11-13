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
                for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
                {
                    int indice = listBox1.SelectedIndices[i];
                    listBox1.Items.RemoveAt(indice);

                }
            }
            if (radioButton2.Checked)
            {

                for (int i = listBox2.SelectedItems.Count - 1; i >= 0; i--)
                {
                    int indice = listBox2.SelectedIndices[i];
                    listBox2.Items.RemoveAt(indice);

                }

            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                BtnEliminar.Text = "Eliminar de 1";

            }
          


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                BtnEliminar.Text = "Eliminar de 2";

            }
          
        }

        private void BtnTraspasar_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                var hola = listBox1.SelectedItems[0];
                listBox2.Items.Add(hola);
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
