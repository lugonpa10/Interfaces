#define OPCION 

using System.Diagnostics;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if OPCION1
            int res = 0;
            Console.WriteLine("Introduce un numero");
            int num = Convert.ToInt32(Console.ReadLine());

            Factorial(num, ref res);
            Console.WriteLine("Resultado: {0}", res);
#else


 

            posicionAleatoria();





#endif

        }


        static bool Factorial(int num, ref int acu)

        {
            acu = 1;


            if (num < 0 || num > 10)
            {
                //   Debug.WriteLine("falso");
                return false;


            }
            else
            {
                for (int i = 1; i <= num; i++)
                {

                    acu = acu * i;
                }

                return true;
            }






        }

        static void posicionAleatoria(int cantAsteriscos = 10)
        {

            Random generador = new Random();

            for (int i = 0; i < cantAsteriscos; i++)
            {
                Console.SetCursorPosition(generador.Next(1, 21), generador.Next(1, 11));

                Console.WriteLine("*");
            }
            Console.ReadLine();



        }
    }
}
