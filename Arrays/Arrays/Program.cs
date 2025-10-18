namespace Arrays
{



    //enum Dias
    //{
    //    Lunes = 1,
    //    Martes,
    //    Miercoles,
    //    Jueves,
    //    Viernes,
    //    Sabado,
    //    Domingo
    //}
    //enum Bancos
    //{
    //    Abanca = 2080,
    //    Bankia = 3922,
    //    BBVA = 1020,
    //    Bankinter = 3021,
    //    BSCH = 4231,
    //    Banesto = 3489,
    //    Caixavigo = Abanca
    //}


    internal class Program
    {
        static void Main(string[] args)
        {


            //Dias d = Dias.Lunes;
            //Console.WriteLine(d);

            //d++;
            //Console.WriteLine(d);


            //Dictionary<String, int> edades = new Dictionary<string, int>();
            //// Introducir elementos (clave, valor), la clave es unica (no se puede repetir)
            //edades.Add("Ana", 20);
            //edades.Add("Juan", 31);
            //edades.Add("Pablo", 2);
            //edades.Add("Maria", 12);
            //edades.Add("Ana MAria", 12);
            //Console.WriteLine("Ana tiene {0} años", edades["Ana"]);

            //// Recorrer la colección pares clave/valor
            //foreach (KeyValuePair<String, int> de in edades) // la ordenacion puede coincidir o no
            //{
            //    Console.WriteLine("{0} tiene {1} años", de.Key, de.Value);
            //}
            //// Recorrer la colección solo de valores
            //foreach (int de in edades.Values)
            //{
            //    Console.WriteLine(de);
            //}
            //// Recorrer la colección solo de claves
            //foreach (string de in edades.Keys)
            //{
            //    Console.WriteLine(de);
            //}



            //int[] v = { 5, 1, 4, 0 };
            //DateTime date = DateTime.Now;
            ////Uso var para evitar el using y una declaración excesivamente larga
            //var culture = new System.Globalization.CultureInfo("es-ES");
            //String day = culture.DateTimeFormat.GetDayName(date.DayOfWeek);
            //Console.WriteLine($"¡Hola! Hoy es {day}, y son las {date:HH:mm}.");
            //Console.WriteLine("Veamos el contenido de un vector");
            //for (int i = 0; i < v.Length; i++)
            //{
            //    Console.WriteLine($"Posición: {i,3}\tValor: {v[i],3}");
            //}
            //int[] v = new int[10];
            //Random g = new Random();
            //Console.WriteLine("El tamaño del vector es {0}", v.Length);
            //for (int i = 0; i < v.Length; i++)
            //{
            //    v[i] = g.Next(-5, 5);
            //}
            //for (int i = 0; i < v.Length; i++)
            //{
            //    Console.WriteLine("Posición: {0,2}\tValor: {1,3}", i, v[i]);
            //}


            //int i, j;
            //int[,] bi = new int[3, 5]; // OJO, cambia respecto a Java.
            //Random g = new Random();
            //Console.WriteLine("Array bidimensional");
            //for (i = 0; i < bi.GetLength(0); i++) // Cantidad de filas
            //{
            //    for (j = 0; j < bi.GetLength(1); j++) // Cantidad de columnas
            //    {
            //        bi[i, j] = g.Next(1, 21);
            //    }
            //}
            //for (i = 0; i <= bi.GetUpperBound(0); i++) // Limite superior de filas
            //{
            //    for (j = 0; j <= bi.GetUpperBound(1); j++) //Limite superior de columnas
            //    {
            //        Console.Write("{0,3}", bi[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("El nº de dimensiones del array es {0}", bi.Rank);
            //Console.WriteLine("Cantidad total :{0}",bi.Length); // cantidad total de elementos (en este caso 3*5 = 15)

        }
    }
}
