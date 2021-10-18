using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDice {
    class Dice {
        int die;
        int roll;

        public Dice() {
            die = 6;
            roll = 0;
        }

        public int diceRoll() {
            Random random = new Random();
            
            return random.Next(1, die);
        }
    }
}
