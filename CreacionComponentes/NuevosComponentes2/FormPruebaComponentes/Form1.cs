using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPruebaComponentes
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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawString("Prueba de escritura de texto",
            //this.Font, Brushes.BlueViolet, 10, 10);
            //          e.Graphics.FillEllipse(Brushes.Aquamarine, 10, 30, 100, 50);
        }
        bool pintar = true;
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (pintar)
            {

                e.Graphics.DrawString("Prueba de escritura de texto",
    this.Font, Brushes.BlueViolet, 10, 10);
                e.Graphics.FillEllipse(Brushes.Aquamarine, 10, 30, 100, 50);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pintar = !pintar;
            this.Refresh();
            this.Text= pintar.ToString();
            //Graphics gr = this.CreateGraphics();
            //gr.DrawString("Escribo fuera del OnPaint", this.Font, Brushes.BlueViolet, 10, 100);
            //gr.DrawImage(new Bitmap(@"C:\Windows\Web\Wallpaper\Theme2\img7.jpg"), 10, 130);


        }
    }

}
