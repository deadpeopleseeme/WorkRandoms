namespace WorkCSRandomizer

{
    internal class Program
    {  
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Eddy\\Desktop\\randoms\\1.txt";
            while (true)
            {
                MyWriter writer = new();
                writer.WriteRandomsToFile(path);
                MyReader.ReadRandomsFromFile(path);
                Console.WriteLine("\n-----PRESS ANY KEY FOR A NEW RANDOM----\n");
                Console.ReadKey();
            }
        }
    }
}
