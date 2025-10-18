namespace Objetos
{


    internal class Program
    {
        static void Main(string[] args)
        {
            Perro objPerro = new Perro(); // se puede poner solo new()

            objPerro.Raza = "Mastín";
            objPerro.nombre = "Laika";
            objPerro.Edad = -5;
            Console.WriteLine(objPerro.Edad);
            Console.ReadLine();
        }
    }
}
