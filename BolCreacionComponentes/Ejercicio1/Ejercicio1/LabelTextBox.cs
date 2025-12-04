using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Ejercicio1
{
    public partial class LabelTextBox: UserControl
    {
        public enum EPosicion
        {
            IZQUIERDA, DERECHA
        }
        public LabelTextBox()
        {
            InitializeComponent();
           
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
                    recolocar();
                    OnPosicionChanged(EventArgs.Empty);
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
                    txt.Width = 200;
                    //Establecemos altura del componente
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    this.Width = (lbl.Width + Separacion + txt.Width);

                    break;
                case EPosicion.DERECHA:
                    //Establecemos posición del componente txt
                    txt.Location = new Point(0, 0);
                    //Establecemos ancho del Textbox
                    txt.Width = 200;
                    //Establecemos posición del componente lbl
                    lbl.Location = new Point(txt.Width + Separacion, 0);
                    //Establecemos altura del componente (Puede sacarse del switch)
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    this.Width = (lbl.Width + Separacion+ txt.Width);
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
                    recolocar();
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

        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad Posicion cambia")]
        public event System.EventHandler SeparacionChanged;

        protected virtual void OnSeparacionChanged(EventArgs e)
        {
           SeparacionChanged?.Invoke(this, e);
        }

        private void txt_KeyUp(object sender,KeyEventArgs e)
        {
            this.OnKeyUp(e);
        }
        protected virtual void OnKeyUp(EventArgs e)
        {
            Console.WriteLine("Evento Key_Up");
        }


        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad Posicion cambia")]
        public event System.EventHandler TxtChanged;

        protected virtual void OnTxtChanged(EventArgs e)
        {
            TxtChanged?.Invoke(this, e);
            Console.WriteLine("Evento TxtChanged");
            


        }

        private void txt_TxtChanged(object sender,EventArgs e)
        {
            this.OnTxtChanged(e);
        }


        private char pswChr;
        [Category("Mis Propiedades")]
        [Description("Contraseña asociada al TextBox interno")]
        

        public char PswChr
        {
            set { txt.PasswordChar = value; }
            get { return txt.PasswordChar; }
        }
        


       





    }
}
