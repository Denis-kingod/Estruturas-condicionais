using System;

namespace nadadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Para começarmos coloque a sua idade!");
            int idade = int.Parse(Console.ReadLine());

             if (idade > 18)
            {
                Console.WriteLine("Nadadores senior");
            }else {
                if (idade > 16)
                {
                    Console.WriteLine("Juvenil B");
                }else {
                    if (idade > 12 )
                    {
                        Console.WriteLine("Juvenil A");
                    }else {
                        if (idade > 7)
                        {
                            Console.WriteLine("Infantil B");
                        }else {
                            if (idade > 4)
                            {
                                Console.WriteLine("Infantil A");
                            }else {
                                Console.WriteLine("Infelizmente só permitimos a idade a partir de 5 anos...");
                            }                            
                        }
                    }
                }
            }
        }
    }
}
