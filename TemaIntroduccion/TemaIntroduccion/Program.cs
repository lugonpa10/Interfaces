using System.Drawing;

namespace TemaIntroduccion
{
    internal class Program
    {

        static void suma(int a, int b, int c)
        {
            c = a + b;
        }
        static void Main(string[] args)
        {

            int n1 = 3;
            int n2 = 5;
            int res = 0;

            suma(n1, n2, res);

            Console.WriteLine(res);


            //int a;
            //Int32 b; // sinonimo de int


            //Console.WriteLine("Hello, World!"); //println snippet: cw

            //Console.Write(@"https:\\www.miurl.com\dir1\otrdir\index.html"); // con el @ no es necesario poner tantos caracteres de escape.
            //Console.WriteLine();
            //Console.WriteLine("Un \ttabulador\nlínea distinta");

            //int? c = null; // Por defecto no se puede poner null a estos tipos de datos, poniendole una interrogacion se puede "nulizar"

            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i++); // postincremento, en este caso empieza en 0 (muestra y luego incrementa)
            //} while (i < 5);
            //Console.WriteLine();
            //i = 0;
            //do
            //{
            //    Console.WriteLine(++i); // preincremento, en este caso empieza en 1 (incrementa y luego muestra)
            //} while (i < 5);




            //string nom;
            //Console.WriteLine("Por favor introduce tu nombre");
            //nom = Console.ReadLine();
            //switch (nom)
            //{
            //    case "adios":
            //    case "Adios":
            //    case "ADIOS":
            //        Console.WriteLine("Hasta la próxima");
            //        break;
            //    case "Curro":
            //        Console.WriteLine("Acceso denegado, cámbiate el nombre");
            //        goto case "ADIOS";
            //    default:
            //        Console.WriteLine("Hola {0}, bienvenido a este programa",
            //       nom);
            //        break;
            //}

        }
    }
}
