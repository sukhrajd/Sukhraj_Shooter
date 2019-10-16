using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sukhraj_Shooter
{
  public  class abstractClass
    {

        Random rnd = new Random();
        int clk = 0;
        public int dead() {
            return rnd.Next(1, 4);
        }

        public int result(int rnd) {
            clk++;
            if (clk == rnd)
            {
                return 0;
            }
            else if (clk == 4)
            {
                return 1;
            }
            else {
                return 2;
            }
        }

        //this code is used to shootaway concept  
        public int shootAway() {
            return rnd.Next(1,2);
        }

    }
}
