using System;
using System.Threading.Tasks.Dataflow;

namespace _0sandXs
{
    class Program
    {
        static void Main(string[] args)
        {

              Board one = new Board();
            one.displayBoard();

            Player a = new Player();
            Player b = new Player();



            one.addCounter(0, 0);

            one.addCounter(0, 4);

            one.addCounter(0, 8);


            one.checkWin();
            a.newPerson();
            b.newPerson();
        }
    }
}
