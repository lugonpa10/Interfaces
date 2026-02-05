using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuevosComponentes2
{
    public enum EMarca
    {
        Nada,
        Cruz,
        Circulo,
        Imagen
    }
    public partial class EtiquetaAviso : Control
    {
        public EtiquetaAviso()
        {
            InitializeComponent();
        }

        private EMarca marca = EMarca.Nada;
        [Category("Appearance")]
        [Description("Indica el tipo de marca que aparece junto al texto")]
        public EMarca Marca
        {
            set
            {
                marca = value;
                this.Refresh();
            }
            get
            {
                return marca;
            }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            if (gradiente)
            {
                LinearGradientBrush l = new LinearGradientBrush(this.ClientRectangle, color1, color2, LinearGradientMode.Horizontal);
                g.FillRectangle(l, this.ClientRectangle);
                l.Dispose();

            }
            int grosor = 0; //Grosor de las líneas de dibujo
            int offsetX = 0; //Desplazamiento a la derecha del texto
            int offsetY = 0; //Desplazamiento hacia abajo del texto
                             // Altura de fuente, usada como referencia en varias partes
            int h = this.Font.Height;
            //Esta propiedad provoca mejoras en la apariencia o en la eficiencia
            // a la hora de dibujar
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //Dependiendo del valor de la propiedad marca dibujamos una
            //Cruz o un Círculo
            switch (Marca)
            {
                case EMarca.Circulo:
                    grosor = 20;
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor,
                    h, h);
                    offsetX = h + grosor;
                    offsetY = grosor;
                    zonaEvento = new Rectangle(0, 0, h, h);

                    break;
                case EMarca.Cruz:
                    grosor = 3;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, h, h);
                    g.DrawLine(lapiz, h, grosor, grosor, h);
                    offsetX = h + grosor;
                    offsetY = grosor / 2;
                    zonaEvento = new Rectangle(0, 0, h, h);

                    //Es recomendable liberar recursos de dibujo pues se
                    //pueden realizar muchos y cogen memoria
                    lapiz.Dispose();
                    break;
                case EMarca.Imagen:
                    if(imagenMarca != null)
                    {
                        g.DrawImage(imagenMarca, 0, 0, h, h);
                        offsetX = h;
                    }

                    zonaEvento = new Rectangle(0, 0, h, h);
                    break;


            }
            //Finalmente pintamos el Texto; desplazado si fuera necesario
            SolidBrush b = new SolidBrush(this.ForeColor);
            g.DrawString(this.Text, this.Font, b, offsetX + grosor, offsetY);
            Size tam = g.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY * 2);
            b.Dispose();
            Point x = new Point(0);
            Point y = new Point(200);


        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }
        private Color color1;
        [Category("Mis propiedades")]
        [Description("Color 1 para el gradiente")]
        public Color Color1
        {
            set
            {
                color1 = value;
                Refresh();
            }
            get
            {
                return color1;
            }
        }
        private Color color2;
        [Category("Mis propiedades")]
        [Description("Color 2 para el gradiente")]
        public Color Color2
        {
            set
            {
                color2 = value;
                Refresh();
            }
            get
            {
                return color2;
            }
        }

        private bool gradiente;
        [Category("Mis propiedades")]
        [Description("Si esta a True muestra un degradado en el color")]

        public bool Gradiente
        {
            set
            {
                gradiente = value;
                Refresh();
            }
            get
            {
                return gradiente;
            }
        }

        private Image imagenMarca;
        [Category("Mis Propiedades")]
        [Description("Muestra una imagen que escoja el usuario")]
        public Image ImagenMarca
        {
            set
            {
                imagenMarca = value;
            }
            get
            {
                return imagenMarca;
            }
        }
        [Category("Acción")]
        [Description("Se lanza cuando se hace click en la marca")]
        public event EventHandler ClickEnMarca;
        public Rectangle zonaEvento;

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if(marca != EMarca.Nada && zonaEvento.Contains(e.Location))
            {
                ClickEnMarca?.Invoke(this, EventArgs.Empty);

            }

        }





      





    }
}
