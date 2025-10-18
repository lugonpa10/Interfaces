using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemaWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Tag = Color.Magenta;
            button2.Tag = Color.Lime;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Text = "1";

            Button b = (Button)sender;

             ((Button)sender).Text = ((Button)sender).Text.ToUpper();
            this.BackColor = (Color)b.Tag;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Text = Properties.Resources.Cadena; // seguir los nombres,archivos de recursos
            //button2.Text = button2.Text.ToUpper();
        }
        private void Form1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            this.Text = e.KeyCode.ToString();

        } // utilizar con key preview  a true 
    
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Mi Aplicación",
MessageBoxButtons.YesNo, MessageBoxIcon.Question)
== DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
