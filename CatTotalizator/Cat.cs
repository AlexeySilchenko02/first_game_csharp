using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatTotalizator
{
    public class Cat
    {
        public static int totalCatsInTheGame = 10;
        public int catNumber;
        public int catSpeed;
        public double GetCatTime(int interval)
        {
            return (interval / catSpeed);
        }
    }
}
