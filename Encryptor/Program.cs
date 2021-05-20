using System;

namespace Encryptor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva o texto para codificar: ");
            string word = Console.ReadLine();
            Console.WriteLine(word.Encrypt());
        }
    }
}
