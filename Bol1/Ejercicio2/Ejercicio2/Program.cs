namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            int edad =0;
            double peso =0.0;

            Console.WriteLine("Escribe tu nombre,tu edad y tu peso");
            //Console.WriteLine();
            nombre = Console.ReadLine();
            edad=int.Parse(Console.ReadLine());
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Nombre:{0,12}, Edad:{1,4}\n \tPeso:{2,5:F1}\n \"{0}\" \\{1}\\ ", nombre,edad,peso);






        }
    }
}
