using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace _0sandXs
{
    class Player
    {
        public string Character;
        static int number = 0;


        public string newPerson()
        {
            int playerNo = number;

            if(playerNo == 0)
            {
                Character = "O";
            }
            if (playerNo == 1
                )
            {
                Character = "X";
            }

            number = number++;
            return Character;
        }
    }
}
