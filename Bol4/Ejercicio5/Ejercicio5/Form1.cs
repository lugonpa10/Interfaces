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

                button.MouseEnter += cambio_color;
                button.MouseLeave += cambio_color;
                button.MouseClick += pulsar_boton;
               



            }
        }

        private void cambio_color(object sender, EventArgs e)
        {

            Button btn = (Button)sender;

            if (btn.BackColor != Color.Green)
            {

                if (btn.BackColor == DefaultBackColor)
                {
                    btn.BackColor = Color.Red;
                }
                else
                {
                    btn.BackColor = DefaultBackColor;

                }
            }








        }
        private void pulsar_boton(object sender, EventArgs e)
        {
            Button btn = (Button)sender;


            btn.BackColor = Color.Green;


        }

        private void Texto(object sender,EventArgs e)
        {
            
        }





    }
}
