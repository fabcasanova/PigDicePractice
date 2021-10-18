using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDice {
    class Game {
        SortedList<int, Player> players;
        int total;
        public Game() {
            this.players = new SortedList<int, Player>();
            this.total = 0;
        }

        public void startGame() {
            Console.WriteLine("Welcome to Pig Game");
            Console.Write("Enter Total Amount of Players:\t");
            total = Console.Read();
            setTotalPlayers(total);
        }

        public void setTotalPlayers(int total) {
            if (total == 0) {
                Console.WriteLine("Exiting");

            }
            else {
                for (int i = 1; i <= total; i++) {
                    Console.Write("Enter Player #" + i + " Name:\t");
                    String name = Console.ReadLine();
                    Player player = new Player();
                    player.setName(name);
                    players.Add(i, player);
                }
            }
         }

        public void startDiceRolls() {
            Dice dice = new Dice();
            
            for (int i = 1; i <= total; i++) {
                int newRoll = dice.diceRoll();
                Console.WriteLine("Player: " + players[i].getName() + "'s dice roll is: " + newRoll);
            }
        }
    
    }
}
