using System;

namespace Uri_1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b, c;

            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();

            if(a =="vertebrado")
            {
                if(b=="ave")
                {
                    if(c=="carnivoro")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Aguia");
                    }
                    else if(c == "onivoro")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Pomba");
                    }
                }

                else if(b == "mamifero")
                {
                    if(c=="onivoro")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Homem");
                    }

                    else if(c=="herbivoro")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Vaca");
                    }
                }

            }

            if (a == "invertebrado")
            {
                if (b == "inseto")
                {
                    if (c == "hematofago")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Pulga");
                    }
                    else if (c == "herbivoro")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Lagarta");
                    }
                }

                else if (b == "anelideo")
                {
                    if (c == "hematofago")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Sanguessuga");
                    }

                    else if (c == "onivoro")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Minhoca");
                    }
                }

            }

            
        }
    }
}
