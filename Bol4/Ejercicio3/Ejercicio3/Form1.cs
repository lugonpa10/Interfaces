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
    public partial class Form1 : Form//Titulo al principio. Icono en sec. Si se cancela o hay error de imagen que no abra formulario.
    {
        int seg = 0;
        int min = 0;
        public Form1()
        {
            InitializeComponent();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevaImg_Click(object sender, EventArgs e)
        {

            string rutaArchivo = "";
            string nombreArchivo = "";
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Escoge una imagen";
                ofd.InitialDirectory = "c:\\";
                ofd.Filter = "Archivos JPG (*.jpg)|*.jpg|Archivos PNG (*.png)|*.png|Todos los archivos (*.*)|*.*;  ";
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    rutaArchivo = ofd.FileName;
                    nombreArchivo = Path.GetFileName(ofd.FileName);




                    try
                    {
                        Form2 f2 = new Form2(rutaArchivo);

                        f2.Text = nombreArchivo;

                        if (checkModal.Checked)
                        {
                            f2.ShowDialog();
                        }
                        else
                        {

                            f2.Show();
                        }



                    }
                    catch (ArgumentException)
                    {
                        MessageBox.Show("Error en la escritura de la imagen",
                            "Error Imagen",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error con el archivo",
                            "Error Archivo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }



                }


            }
        }

        private void checkModal_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;
            if (checkModal.Checked)
            {
                checkModal.ForeColor = Color.Red;


            }
            else
            {
                checkModal.ForeColor = Color.Black;

            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {


            seg++;
            if (seg >= 60)
            {
                seg = 0;
                min++;

            }

            this.Text = $"Visor de imagenes {min:D2}:{seg:D2}";






        }
    }
}
