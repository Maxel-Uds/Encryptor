using System;

namespace Encryptor
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            int n = 0;
            bool error = false;
            do
            {
                try
                {
                    do
                    {
                        error = false;
                        Console.WriteLine("Selecione uma opção:");
                        Console.WriteLine("[1] Codificar");
                        Console.WriteLine("[2] Decodificar");
                        Console.WriteLine("[0] Sair");
                        Console.Write("Opção: ");
                        n = int.Parse(Console.ReadLine());

                        if(n != 1 && n != 2 && n != 0)
                        {
                            Console.WriteLine($"A opção {n} é inválida!");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    } while(n != 1 && n != 2 && n != 0);

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

                    if(n != 0)
                    {
                        do {
                            Console.Write("Para codificar outro texto digite 3, para sair digite 0: ");
                            n = int.Parse(Console.ReadLine());
                            Console.Clear();
                            if(n != 3 && n != 0)
                            {
                                Console.WriteLine($"A opção {n} é inválida!");
                                Console.ReadLine();
                                Console.Clear();
                            }
                        } while(n != 3 && n != 0);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                    Console.ReadLine();
                    Console.Clear();
                    error = true;
                }
            } while((n != 3 && error) || n == 3);
        }
    }
}
