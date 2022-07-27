using System;
using desafio_code.src.Entities;


namespace desafio_code
{
    class Program
    {
        static void Main(string[] args)
        {
           knight arus = new knight(" Arus " ,79 , " guerreiro ");
           Wizard maga = new Wizard("  Jennifer " ,79 , " white wizard" );

           Console.Write(arus.Attack() );
            Console.Write(maga.Attack(1) );
         
           
        }
    }
}
