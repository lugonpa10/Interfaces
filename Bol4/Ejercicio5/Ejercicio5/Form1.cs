using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button button;
            int x = 50;
            int y = 50;
            
            for (int i = 0; i < 12; i++)
            {
                button = new Button();
                if (i % 3 == 0)
                {
                    x = 50;
                    y += 60;
            int x = 0;
            int y = 0;
            for (int i = 0; i < 12; i++)
            {
                button = new Button();

                if (i % 3 == 0)
                {
                    x = 40;
                    y += 40;


                }
                else
                {
                    x += 80;
                }

                button = new Button();
                button.Text = i.ToString();

                if (i == 10)
                {

                    button.Text = "*";

                }
                if (i == 11)
                {
                    button.Text = "#";



                button.Text = (i + 1).ToString();
                if (i == 9)
                {
                    button.Text = "*";
                }
                else if (i == 10)
                {
                    button.Text = "0";
                }
                else if (i == 11)
                {
                    button.Text = "#";

                }

                button.Location = new Point(x, y);
                this.Controls.Add(button);


                button.Click += Interacciones_Botones;
                button.MouseEnter += Colores_Botones;
                button.MouseLeave += Colores_Botones;
                button.Tag = false;
                
                
            }

        }

        private void Interacciones_Botones(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
            button.BackColor = Color.Red;
            button.Tag = true;
            



        }
        private void Colores_Botones(object sender,EventArgs e)
        {
            Button button = (Button)sender;
            bool presionado = (bool)button.Tag;
            if (presionado)
            {
                return;
            }

            if(button.BackColor == DefaultBackColor)
            {
                button.BackColor = Color.Blue;
            }
            else
            {
                button.BackColor = DefaultBackColor;
            }



        }

        private void grabarNumeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDatos frmDatos = new FrmDatos();
            

        }

                MouseEnter += cambio_color;

            }
        }

        private void cambio_color(object sender, EventArgs e)
        {
           Button btn = (Button)sender;
           if(btn.BackColor)

        }



    }
}
