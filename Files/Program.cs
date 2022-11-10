using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string writeText = "You got this bro";
            File.WriteAllText("filename.txt", writeText);

            string readText = File.ReadAllText("filename.txt");
            Console.WriteLine(readText);
        }
    }
}