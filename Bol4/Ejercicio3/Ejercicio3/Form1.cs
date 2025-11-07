using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
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

        private void btnNuevaImg_Click(object sender, EventArgs e)
        {
            string contenidoArchivo ="";
            string rutaArchivo = "";
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Escoge una imagen";
                ofd.InitialDirectory = "c:\\";
                ofd.Filter = "Archivos JPG (*.jpg)|*.jpg|Archivos PNG (*.png)|*.png|Todos los archivos (*.*)|*.*;  ";
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    rutaArchivo=ofd.FileName;

                    var fileStream = ofd.OpenFile();

                    using (StreamReader sr = new StreamReader(fileStream))
                    {
                        contenidoArchivo=sr.ReadToEnd();
                    }
                    
                }

            }
            MessageBox.Show(contenidoArchivo, "File Content at path: " + rutaArchivo, MessageBoxButtons.OK);
        }

        
    }
}
