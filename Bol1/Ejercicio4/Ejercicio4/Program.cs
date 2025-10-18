namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("Elige una opcion");
                Console.WriteLine("1.Año bisiesto");
                Console.WriteLine("2.Suma de Rango de numeros");
                Console.WriteLine("3.Todas las opciones");
                Console.WriteLine("4.Salir");
                Console.WriteLine("Elige una opcion");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        int anio;
                        Console.WriteLine("Introduzca un año");
                        anio = Convert.ToInt32(Console.ReadLine());
                        if (anio < 0 || anio > 10000)
                        {
                            Console.WriteLine("año no valido");
                            goto case 1;
                        }
                        else
                        { // TODO enunciado

                            if (Bisiesto(anio))
                            {
                                Console.WriteLine("Si es bisiesto");
                            } else
                            {
                                Console.WriteLine("No es bisiesto");
                            }
                          
                        }

                        if (opcion == 3)
                        {
                            goto case 2;
                        }
                        break;




                    case 2:
                        int num1;
                        int num2;

                        Console.WriteLine("Introduce 2 numeros");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        num2 = Convert.ToInt32(Console.ReadLine());

                        if (num1 < 0 || num2 < 0 || num1 > 10000 || num2 > 10000)
                        {
                            Console.WriteLine("Hay al menos un numero no valido");
                            goto case 2;
                        }
                        else
                        {

                            int? resultado = SumaRangos(num1, num2);

                            if (resultado == null)
                            {
                                Console.WriteLine("El primer numero es mayor que el segundo");

                            }
                            else
                            {
                                Console.WriteLine("El resultado es: " + resultado);
                            }


                        }
                        break;



                    case 3:
                        goto case 1;


                    case 4:
                        Console.WriteLine("Adios");
                        break;




                }
            }
            while (opcion != 4);





        }

        static Boolean Bisiesto(int anio)//RETO simplifiar
        {
            if (anio % 4 == 0 && anio % 100 != 0)
            {
                return true;

            }
            else if ( anio % 400 == 0)
            {
                return true;
            }
            else  
            {
                return false;
            }
            
        }


        static int? SumaRangos(int num1, int num2)
        {


            if (num1 > num2)
            {
                return null;

            }
            int res = 0;
            for (int i = num1; i <= num2; i++)
            {
                res = res + i;
            }



            return res;

        }

    }
}
