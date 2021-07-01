using System;

namespace calculoAno
{
    class Program
    {
        public static int idadeSemana;

        static void Main(string[] args)
        {
            Console.WriteLine("calculo da idade \n");
            Console.WriteLine("qual sua idade atual?");
            int anoAtual = int.Parse(Console.ReadLine());


            int idade = (int)(idadeSemana *52.143);
            Console.WriteLine("sua idade em semanas é:");
        }
    }
}
