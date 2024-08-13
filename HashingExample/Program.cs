using System.Security.Cryptography;
using System.Text;

namespace HashingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //String strInput = "Hello World";

            //Scanner scan = new Scanner(Systen.in);

            Console.Write("Skriv in din text: ");
            String strInput = Console.ReadLine();

            //Hackning. Detta simulerar att något okänt händer med data
            strInput += "123";

            Console.WriteLine(strInput);

            //Skapa ett objekt av SHA512 klassen
            SHA512 sha = SHA512.Create();

            //Hasha data, från plain text till Hexadecimalt (Byte Array)
            byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(strInput));

            //Konvertera ByteArray till String värde utan bindessträck mellan värden
            string hex = BitConverter.ToString(hash).Replace("-", "");

            Console.WriteLine(BitConverter.ToString(hash));
            Console.WriteLine(hex);
        }
    }
}