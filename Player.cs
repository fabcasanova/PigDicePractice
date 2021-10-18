using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDice {
    class Player {
        String name;
        int score;

        public Player() {
            this.name = "";
            this.score = 0;
        }

        public void setName(String name) {
            this.name = name;
        }

        public String getName() {
            return name;
        }

        public void setScore(int score) {
            this.score = score;
        }
        public int getScore() {
            return score;
        }

        public bool addToScore(int newRoll) {

            if (newRoll != 1) {
                score += newRoll;

                return true;
            }
            else {
                return false;
            }
        }
    }
}
