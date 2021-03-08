using System;
using System.Threading.Tasks.Dataflow;

namespace _0sandXs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

              Board one = new Board();
            one.displayBoard();

            Player a = new Player();
            Player b = new Player();

            a.person();
            b.person();

            a.symbol("X");
            b.symbol("O");

            one.checkwin();

        }
    }
}
