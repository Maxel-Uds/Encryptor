using System;

namespace Encryptor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("[1] Codificar");
            Console.WriteLine("[2] Decodificar");
            Console.WriteLine("[0] Sair");
            Console.Write("Opção: ");
            int n = int.Parse(Console.ReadLine());
            string word;

            switch (n)
            {
                case 1:
                    Console.Write("Digite o texto para encriptar: ");
                    word = Console.ReadLine();
                    Console.WriteLine(word.Encrypt());
                    break;
                case 2:
                    Console.Write("Digite o texto para desencriptar: ");
                    word = Console.ReadLine();
                    Console.WriteLine(word.DeCrypt());
                    break;
                case 0:
                    break;
            }
        }
    }
}
