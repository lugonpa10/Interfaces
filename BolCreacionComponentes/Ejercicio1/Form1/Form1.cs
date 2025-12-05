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
        ToolTip toolTip1 = new ToolTip();

            static bool flag = false;
        public Form1()
        {
            InitializeComponent();
        }

        //TODO probar eventos de cambio de posicion y separación. keyup, txtchange
        private void button1_Click(object sender, EventArgs e)
        {
            if (labelTextBox1.Posicion == Ejercicio1.LabelTextBox.EPosicion.IZQUIERDA)
            {
                labelTextBox1.Posicion = Ejercicio1.LabelTextBox.EPosicion.DERECHA;
              
            }
            else
            {
                labelTextBox1.Posicion = Ejercicio1.LabelTextBox.EPosicion.IZQUIERDA;
             
            }



        }

      






        private void BtnAumentar_Click(object sender, EventArgs e)
        {
            flag = true;
            labelTextBox1.Separacion += 50;


        }

        private void BtnDisminuir_Click(object sender, EventArgs e)
        {
            if (labelTextBox1.Separacion > 0)
            {
                flag = false;
                labelTextBox1.Separacion -= 50;

            }
            else
            {
                MessageBox.Show("No se puede disminuir la separacion", "Error Espacio",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }




        private void Texto_Botones(object sender, EventArgs e)
        {
            
            toolTip1.SetToolTip(BtnAumentar, "Aumentar 50 la separacion");
            toolTip1.SetToolTip(BtnDisminuir, "Disminuir 50 la separacion");

        }

       

        
        private void labelTextBox1_SeparacionChanged(object sender, EventArgs e)
        {

            if (flag)
            {
                this.Text = "Aumentar";
            }
            else
            {
                this.Text = "Disminuir";
            }
        }

        private void labelTextBox1_PosicionChanged(object sender, EventArgs e)
        {
            this.Text = labelTextBox1.Posicion.ToString();
        }
    }
}
