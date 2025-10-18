using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    



    class Perro
    {
        private string raza;
        public string Raza
        {
            set
            {
                raza = value;
            }
            get
            {
                return raza;
            }

            // public string Raza { set;get;} este es el estandar
        }
        public string nombre;
        private int edad;

        public int Edad
        {
            set
            {
                if (value > 0)
                {
                    this.edad = value; // se puede poner el this o no

                }
                else
                {
                    this.edad = 0;
                }
            }

            get
            {
                return this.edad; // se puede poner el this o no
            }

        }

        //public int getEdad()
        //{
        //    return edad;
        //}
        //public void setEdad(int edad)
        //{
        //    this.edad = edad;
        //}

        public Perro()
        {
            this.Edad = 0;
            this.raza = "";
            this.nombre = "";
        }
    }
}
