using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Ejercicio_5//Refresh en tipo
{
    public partial class ValidateTextBox : UserControl
    {
       public bool esValido = true;
        public enum eTipo
        {
            Numerico, Textual
        }

        public ValidateTextBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
          

            this.Height = txt.Height + 20;
            txt.Width = this.Width - 20;


            Color colorRecuadro;
            Graphics g = e.Graphics;

            if (esValido)
            {
                colorRecuadro = Color.Green;
            }
            else
            {
                colorRecuadro = Color.Red;
            }



            Pen p = new Pen(colorRecuadro);
            g.DrawRectangle(p, 5, 5, this.Width -10,this.Height -10);




        }

        [Category("Mis propiedades")]
        [Description("Accede al texto del componente")]
        public string Texto
        {
            set
            {
                txt.Text = value;
            }
            get
            {
                return txt.Text;
            }
        }

        [Category("Mis propiedades")]
        [Description("Accede a la propiedad Multilinea del componente")]
        public bool Multilinea
        {
            set
            {
                txt.Multiline = value;
            }
            get
            {
                return txt.Multiline;
            }
        }

        private eTipo tipo = eTipo.Textual;
        [Category("Mis propiedades")]
        [Description("Define el tipo de dato del componente")]
        public eTipo Tipo
        {
            set
            {
                tipo = value;
                ValidarTexto();
            }
            get
            {
                return tipo;
            }
        }

        private void ValidarTexto()
        {
            esValido = true;
            switch (tipo)
            {

                case eTipo.Numerico:


                    string textoSinEspacios = txt.Text.Trim();
                    foreach (Char c in textoSinEspacios)
                    {
                        if (!char.IsDigit(c))
                        {
                            esValido = false;
                        }
                    }
                    break;

                case eTipo.Textual:
                    foreach (Char c in txt.Text)
                    {
                        if (!char.IsLetter(c) && c != ' ')
                        {
                            esValido = false;
                        }
                    }

                    break;
            }
            Refresh();
        }

        [Category("Mis eventos")]
        [Description("Accede al TextChange del textBox desde el nuevo componente")]
        public event EventHandler TextoCambiado;
        protected virtual void OnTextoCambiado(EventArgs e)
        {
            TextoCambiado?.Invoke(this, e);
        }


        private void txt_TextChanged(object sender, EventArgs e)
        {
            ValidarTexto();
            OnTextoCambiado(EventArgs.Empty);
        }
    }
}
