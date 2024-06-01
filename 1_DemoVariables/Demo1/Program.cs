using System;

namespace demo
{
    public class Variables
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("C'est l'été!");

            Console.WriteLine("Entrez votre nom :");
            string nom = Console.ReadLine();

            Console.WriteLine("Bienvenue " + nom + "!");

            Object x = 8;
            Console.WriteLine((x as int?) + 6);

            int unEntier = 20;
            byte unByte = 5;
            bool estActif = true;
            char unChar = 'a';
            long unLong = 12345678912;
            double unDouble = 14800.75;
            float unFloat = 85.6f;
            decimal unDecimal = 12345678987654123.5m;
            
            string hello = "Hello";
            char[] chars = { 'a', 'b', 'c' };
            string alpha = new string(chars);
            string salutation = "Bonjour tout le monde!";

            string path = "c:\\Documents\\AEC";
            string path2 = @"c:\Documents\AEC";

            const string uneConstante = "Cette valeur ne changera pas lors de l'execution";
            Console.WriteLine(hello.Length);
            Console.WriteLine(hello.ToUpper());
            Console.WriteLine(hello.ToLower());
            Console.WriteLine(hello.Contains('e'));
            Console.WriteLine(hello.Contains("ll"));
            Console.WriteLine(salutation.Replace("jour", "soir"));
            Console.WriteLine(salutation.Substring(2, 7));

            string question = "Comment allez-vous?";

            Console.WriteLine(salutation);
           
        }
    }
}