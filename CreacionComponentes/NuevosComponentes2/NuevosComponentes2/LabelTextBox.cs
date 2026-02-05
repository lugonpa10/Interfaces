using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuevosComponentes2
{
    //Indica donde está la etiqueta respecto al TextBox
    public enum EPosicion
    {
        IZQUIERDA, DERECHA
    }

    public partial class LabelTextBox : UserControl
    {
        public LabelTextBox()
        {
            InitializeComponent();
            TextLbl = Name;
            TextTxt = "";

        }


        private EPosicion posicion = EPosicion.IZQUIERDA;
        [Category("Appearance")]
        [Description("Indica si la Label se sitúa a la IZQUIERDA o DERECHA del Textbox")]
        public EPosicion Posicion
        {
            set
            {
                if (Enum.IsDefined(typeof(EPosicion), value))
                {
                    posicion = value;
                    Refresh();

                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            get
            {
                return posicion;
            }
        }
        private void recolocar()
        {
            switch (posicion)
            {
                case EPosicion.IZQUIERDA:
                    //Establecemos posición del componente lbl
                    lbl.Location = new Point(0, 0);
                    // Establecemos posición componente txt
                    txt.Location = new Point(lbl.Width + Separacion, 0);
                    //Establecemos ancho del Textbox
                    //(la label tiene ancho por autosize)
                    txt.Width = this.Width - lbl.Width - Separacion;
                    //Establecemos altura del componente
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
                case EPosicion.DERECHA:
                    //Establecemos posición del componente txt
                    txt.Location = new Point(0, 0);
                    //Establecemos ancho del Textbox
                    txt.Width = this.Width - lbl.Width - Separacion;
                    //Establecemos posición del componente lbl
                    lbl.Location = new Point(txt.Width + Separacion, 0);
                    //Establecemos altura del componente (Puede sacarse del switch)
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
            }
        }



        //Pixeles de separación entre label y textbox
        private int separacion = 0;
        [Category("Mis Propiedades")] // O se puede meter en categoría Design.
        [Description("Píxels de separación entre Label y Textbox")]
        public int Separacion
        {
            set
            {
                if (value >= 0)
                {
                    separacion = value;
                    Refresh();
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            get
            {
                return separacion;
            }
        }

        [Category("Mis Propiedades")] // O se puede meter en categoría Appearance.
        [Description("Texto asociado a la Label del control")]
        public string TextLbl
        {
            set
            {
                lbl.Text = value;
                recolocar();
            }
            get
            {
                return lbl.Text;
            }
        }
        [Category("Mis Propiedades")]
        [Description("Texto asociado al TextBox del control")]
        public string TextTxt
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

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            recolocar();
            e.Graphics.DrawLine(new Pen(Color.Violet),
 lbl.Left, this.Height - 1,
 lbl.Left + lbl.Width, this.Height - 1);
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad Posicion cambia")]
        public event System.EventHandler PosicionChanged;

        protected virtual void OnPosicionChanged(EventArgs e)
        {
            if (PosicionChanged != null)
            {
                PosicionChanged(this, e);
            }
        }



    }
}
