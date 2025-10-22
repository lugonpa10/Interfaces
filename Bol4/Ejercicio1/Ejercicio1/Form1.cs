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

            Button button;

            int x = 200;
            int y = 120;

            for (int i = 0; i < 20; i++)
            {
                if (i % 5 == 0)
                {
                    x = 100;
                    y += 40;
                }
                else
                {
                    x += 100;
                }
                button = new Button();
                button.Text = " " + (i + 1);
                button.Location = new Point(x, y);

                this.Controls.Add(button);
                button.MouseMove += Form1_MouseMove;
                button.MouseDown += Form1_MouseDown;





            }



        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {


            this.Text = e.Location.ToString();
            this.Text = $"X: {MousePosition.X}, Y: {MousePosition.Y}";





        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "Mouse Tester";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Text = "Mouse Tester";

            }
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
