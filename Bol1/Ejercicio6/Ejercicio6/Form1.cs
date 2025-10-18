using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        

            textBox1.Text = Console.ReadLine();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show(
         "Quieres sustituir el titulo actual por este texto: \""+ textBox1.Text ,"Pregunta", MessageBoxButtons.YesNo,MessageBoxIcon.Question);


            if (res == DialogResult.Yes)
            {
                this.Text = textBox1.Text; 
            }
        }
    }
}
