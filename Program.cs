using System;

namespace converterIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("converter idade \n");
            Console.WriteLine("sua idade em anos?");
            double Anos = double.Parse(Console.ReadLine());
            double meses = Anos * 12;
            double dias = meses * 30;
            double horas = dias * 24;
            double minutos = horas * 60;

            Console.WriteLine( "se você acha pouco nisso..."+ Anos + "Anos equivale a:"+"\n");
            Console.WriteLine( meses + "meses" + "\n");
            Console.WriteLine( dias + "dias" + "\n");
            Console.WriteLine( horas + "horas" + "\n");
            Console.WriteLine( minutos + "minutos" + "\n");
        }
    }
}
