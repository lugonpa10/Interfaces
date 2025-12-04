using Ejercicio1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (labelTextBox1.Posicion == Ejercicio1.LabelTextBox.EPosicion.IZQUIERDA)
            {
            labelTextBox1.Posicion = Ejercicio1.LabelTextBox.EPosicion.DERECHA;
                this.Text = "Derecha";
            }
            else
            {
            labelTextBox1.Posicion = Ejercicio1.LabelTextBox.EPosicion.IZQUIERDA;
                this.Text = "Izquierda";
            }

            

        }
        



      

        private void BtnAumentar_Click(object sender, EventArgs e)
        {
            labelTextBox1.Separacion += 50;

        }

        private void BtnDisminuir_Click(object sender, EventArgs e)
        {
            if(labelTextBox1.Separacion > 0)
            {
            labelTextBox1.Separacion -= 50;

            }
            else
            {
                MessageBox.Show("No se puede disminuir la separacion","Error Espacio",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

       


        private void Texto_Botones(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(BtnAumentar,"Aumentar 50 la separacion");
            toolTip.SetToolTip(BtnDisminuir,"Disminuir 50 la separacion");

        }
    }
}
