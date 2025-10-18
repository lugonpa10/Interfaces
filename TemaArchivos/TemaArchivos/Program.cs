namespace TemaArchivos
{
    public delegate int Operation(int a, int b);
    internal class Program
    {
        static int Addition(int a, int b)
        {
            return a + b;
        }
        static int Substraction(int a, int b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {

            int[] v = { -2, 9, 1, -7, 9, 4 };
            /* Actúa sobre cada elemento de un array pasándoselo como parámetro a la función. No
            permite la modificación de elementos del array. */
            Array.ForEach(v, item => { Console.WriteLine(item * item); });
            Console.WriteLine("------------------------");

            //int[] v = { 2, 4, 10, 43, 22, 32, 13, 6, 7 };
            //int even = v.Count(n => n % 2 == 0);
            //Console.WriteLine(even);


            //Operation op = (n1, n2) => n1 - n2;//Substraction; // los parametros estan definidos por el delegado (int,string,etc)
            //string res;
            //int n1, n2;
            //Console.WriteLine("Do you want to add or substract?(A/S)");
            //res = Console.ReadLine().Trim().ToUpper();
            //if (res == "A")
            //{
            //    op = new Operation(Addition); // Operation op = Addition;
            //}
            //Console.WriteLine("Input first operand");
            //n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Input second operand");
            //n2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Result: {0}", op(n1, n2));
            //Console.ReadKey();
        }

        //public static void view(int grade)
        //{
        //    Console.ForegroundColor = grade >= 5 ? ConsoleColor.Green : ConsoleColor.Red;
        //    Console.WriteLine($"Student grade: {grade,3}.");
        //    Console.ResetColor();
        //}
        //public static bool pass(int num)
        //{
        //    return num >= 5;
        //}
        //static void Main(string[] args)
        //{
        //    int[] v = { 2, 2, 6, 7, 1, 10, 3 };
        //    Array.ForEach(v, view);
        //    int res = Array.FindIndex(v, pass);
        //    Console.WriteLine($"The first passing student is number {res + 1} in the list.");
        //    Console.ReadKey();


        //string directory;
        //string separator;
        //string fullName;
        //StreamWriter s;
        //// If only use Windows, you don’t need to do this
        //if (Environment.OSVersion.Platform == PlatformID.Unix)
        //{
        //    directory = Environment.GetEnvironmentVariable("HOME");
        //    separator = "/";
        //}
        //else
        //{
        //    directory = Environment.GetEnvironmentVariable("userprofile");
        //    separator = "\\";
        //}
        //fullName = directory + separator + "testfile.txt";

        //// Open File
        //s = new StreamWriter(fullName);
        //// Write File
        //for (int i = 1; i <= 10; i++)
        //{
        //    s.Write("{0,-2}", i);
        //}
        //s.WriteLine();
        //for (int i = 1; i <= 10; i++)
        //{
        //    s.WriteLine($"Line :{i,3}");
        //}
        //// Close File. Needs try-catch.
        //s.Close();

        //s = new StreamWriter(fullName, true); // escribe cosas si esta a true
        //s.WriteLine("Appending text to file");
        //s.Close();

        //string line;
        //StreamReader sr;
        //sr = new StreamReader(fullName);
        //line = sr.ReadLine();
        //while (line != null)
        //{
        //    Console.WriteLine(line);
        //    line = sr.ReadLine();
        //}
        //sr.Close();


        //using (sr = new StreamReader(fullName)) // cierre automatico
        //{
        //    Console.WriteLine(sr.ReadToEnd());

        //}
        ////sr = new StreamReader(fullName);
        ////Console.WriteLine(sr.ReadToEnd());
        ////sr.Close();
        ///

        //DirectoryInfo d;
        //string systemRoot = Environment.GetEnvironmentVariable("SystemRoot");
        //Console.WriteLine($"{"Current directory:",-20}{Directory.GetCurrentDirectory()}");
        //Console.WriteLine($"{"Change to:",-20}{systemRoot}");
        //Directory.SetCurrentDirectory(systemRoot);
        //d = new DirectoryInfo(Directory.GetCurrentDirectory());
        //Console.WriteLine($"Subdirectories of {d.Name}");
        //foreach (DirectoryInfo dirs in d.GetDirectories())
        //{
        //    Console.WriteLine($"\t{dirs.Name}");
        //}
        //Console.WriteLine("Files:");
        //foreach (FileInfo f in d.GetFiles())
        //{
        //    Console.WriteLine($"\t{f.Name}");
        //}






    }
}

