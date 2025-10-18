#define PRUEBA

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Ejercicio3
{

    public partial class Form1 : Form
    {
        int cont = 50;
        



        public Form1()
        {
            InitializeComponent();
            if (cont >= 0)
            {
                cont = 0;
            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var (num1, num2, num3) = Aleatorios(1, 7);


            cont = cont - 2;
            label2.Text = cont.ToString();
            label1.Visible = false;

            textBox1.Text = num1.ToString();
            textBox2.Text = num2.ToString();
            textBox3.Text = num3.ToString();

            if (num1 == num2 && num1 == num3)
            {
                label1.Visible = true;
                label1.Text = "PREMIO: 20 EUROS";
                cont = cont + 20;
                label2.Text = cont.ToString();
            }
            else if (num1 == num2 || num1 == num3 || num2 == num3)
            {
               
#if PRUEBA
                label1.Visible = true;
                label1.Text = "Mala suerte: -5 euros";
                cont = cont - 5;
                label2.Text = cont.ToString();


#else
                label1.Visible = true;
                label1.Text = "PREMIO: 5 EUROS";
                cont = cont + 5;
                label2.Text = cont.ToString();



#endif
                label2.Text = cont.ToString();
            }




        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Creditos_Click(object sender, EventArgs e)
        {

            cont = cont + 10;
            label2.Text = cont.ToString();
        }

         (int, int, int) Aleatorios(int minimo, int maximo)
        {

            Random random = new Random();
            int num1 = random.Next(minimo, maximo + 1);
            int num2 = random.Next(minimo, maximo + 1);
            int num3 = random.Next(minimo, maximo + 1);
            return (num1, num2, num3);
        }

        private void label1_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}
