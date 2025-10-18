namespace Ejercicio9
{
    public class Ordenador
    {
        static void Main(string[] args)
        {
            Dictionary<String, Ordenador> ordenadores = new Dictionary<string, Ordenador>();






            int opcion = 0;
            do
            {
                Console.WriteLine("1-Añadir un nuevo equipo");
                Console.WriteLine("2-Añadir varios equipos");
                Console.WriteLine("3-Eliminar un dato");
                Console.WriteLine("4-Mostrar la coleccion");
                Console.WriteLine("5-Muestra un elemento");
                Console.WriteLine("6-Salir");
                opcion = PedirEnteroRango(1, 6);
                switch (opcion)
                {
                    case 1:

                        Ordenador ordenador = new Ordenador();

                        string ip = PedirIp();

                        int ram = PedirRam();
                        ordenador.Ram = ram;

                        ordenadores.Add(ip, ordenador);



                        break;

                    case 2:


                        break;


                    case 3:


                        break;


                    case 4:

                        foreach (string ips in ordenadores.Keys)
                        {
                            Console.WriteLine("Lista de las IP {0}", ips);

                        }

                        break;

                    case 5:



                        break;
                }



            }
            while (opcion != 6);
        }
        private string nombre;

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }

        }
        private int ram;

        public int Ram
        {
            set
            {
                ram = value;
            }
            get
            {
                return ram;
            }
        }

        public static bool IPValida(string cadena)
        {
            if (cadena.Split('.').Length == 4)
            {
                return true;

            }
            return false;
        }
        static string PedirIp()
        {
            string ip;

            do
            {
                Console.WriteLine("Introduce una dirección IP: ");
                ip = Console.ReadLine();

                if (!IPValida(ip))
                {
                    Console.WriteLine("IP no válida, inténtalo de nuevo.");
                }

            } while (!IPValida(ip));

            return ip;
        }

        static int PedirRam()
        {
            int ram;
            do
            {
                Console.WriteLine("Introdce la ram");
                ram = Convert.ToInt32(Console.ReadLine());

                if (ram < 0)
                {
                    Console.WriteLine("ram no valida,introduzca nueva");
                    ram = Convert.ToInt32(Console.ReadLine());
                }
            } while (ram < 0);

            return ram;
        }












        static int PedirEnteroRango(int min, int max)
        {
            int num;
            bool flag;
            do
            {
                Console.WriteLine("Introduce una opcion entre {0} y {1}", min, max);
                flag = int.TryParse(Console.ReadLine(), out num);
                if (num < min || num > max)
                {
                    Console.WriteLine("Numero fuera de rango");
                }

            }
            while (!flag);

            return num;
        }

    }

}
