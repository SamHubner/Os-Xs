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
        int playerNo;

        public string newPerson()
        {
            int playerNo = number;

            number = number++;
            return Character;
        }

    }
}
