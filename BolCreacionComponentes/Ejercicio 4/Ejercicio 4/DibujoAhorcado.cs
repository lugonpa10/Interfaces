using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4
{
    public partial class DibujoAhorcado : UserControl
    {
        public DibujoAhorcado()
        {
            InitializeComponent();
        }

        private int errores;
        [Category("Mis propiedades")]
        [Description("Errores")]
        public int Errores
        {
            set
            {

                if (errores != value)
                {
                    errores = value;
                    OnCambiaError(EventArgs.Empty);

                    if (errores >= 8)
                    {
                        OnAhorcado(EventArgs.Empty);
                    }
                    this.Refresh();

                }

            }
            get
            {
                return errores;
            }
        }

        [Category("Accion")]
        [Description("Se lanza cuando cambia el numero de errores")]
        public event EventHandler CambiaError;
        protected virtual void OnCambiaError(EventArgs e)
        {
            CambiaError?.Invoke(this, e);
        }

        [Category("Accion")]
        [Description(" se lanza cuando se completa el dibujo.")]
        public event EventHandler Ahorcado;
        protected virtual void OnAhorcado(EventArgs e)
        {
            Ahorcado?.Invoke(this, e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int x = this.Width;
            int y = this.Height;

            Pen lapiz = new Pen(Color.Black, 3);
            if (errores >= 1)
            {
                g.DrawLine(lapiz, x * 0.1f, y * 0.9f, x * 0.5f, y * 0.9f);

            }
            if (errores >= 2)
            {
                g.DrawLine(lapiz, x * 0.1f, y * 0.9f, x * 0.1f, y * 0.1f);
            }
            if (errores >= 3)
            {
                g.DrawLine(lapiz, x * 0.1f, y * 0.1f, x * 0.3f, y * 0.1f);
            }
            if (errores >= 4)
            {
                g.DrawLine(lapiz, x * 0.3f, y * 0.1f, x * 0.3f, y * 0.2f);
            }
            if (errores >= 5)
            {
                float diametroCabeza = y * 0.15f;
                g.DrawEllipse(lapiz, x * 0.3f - diametroCabeza / 2, y * 0.2f, diametroCabeza, diametroCabeza);
            }
            if (errores >= 6)
            {
                g.DrawLine(lapiz, x * 0.3f, y * 0.35f, x * 0.3f, y * 0.6f);
            }
            if (errores >= 7)
            {
                g.DrawLine(lapiz, x * 0.3f, y * 0.6f, x * 0.1f, y * 0.7f);
            }
            if (errores >= 8)
            {
                g.DrawLine(lapiz, x * 0.3f, y * 0.6f, x * 0.5f, y * 0.7f);
            }

            lapiz.Dispose();
        }

    }
}
