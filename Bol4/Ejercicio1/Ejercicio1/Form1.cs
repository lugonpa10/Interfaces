using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Mouse Tester";
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;



        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.Location.ToString();
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "Mouse Tester";
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            this.Text = e.KeyCode.ToString();

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

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (MouseButtons == MouseButtons.Right)
            {
                button2.BackColor = Color.Red;
            }
            else if (MouseButtons == MouseButtons.Left)
            {
                button1.BackColor = Color.Blue;
            }
            else
            {
                button1.BackColor = Color.Blue;
                button2.BackColor = Color.Red;

            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
           button1.BackColor = Color.White;
            button2.BackColor = Color.White;


        }

       
    }
}
