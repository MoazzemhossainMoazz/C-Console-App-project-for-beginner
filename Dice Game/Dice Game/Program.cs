using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoint = 0;
            int enemyPoint = 0;

            Random random = new Random();

            for(int i=0; i<5; i++)
            {
                Console.WriteLine("\n----------------------------------");
                Console.WriteLine("\nPlease any key to roll the dice.\n");

                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("\nYou rolled a " + " " + playerRandomNum);

                System.Threading.Thread.Sleep(500);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy AI rolled a " + enemyRandomNum);


                if(playerRandomNum > enemyRandomNum)
                {
                    playerPoint++;
                    Console.WriteLine("You wins this round!");
                }
                else if(playerRandomNum < enemyRandomNum)
                {
                    enemyPoint++;
                    Console.WriteLine("Enemy wins this round!");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }

                Console.WriteLine("The score is now= You: " + playerPoint + " and " + "Enemy:" + enemyPoint);
            }

            if(playerPoint > enemyPoint)
            {
                Console.WriteLine("\n\n################################################");
                Console.WriteLine("######### Congratulations!!! Your win!!! ########");
                Console.WriteLine("################################################");
            }

            else if(playerPoint < enemyPoint)
            {
                Console.WriteLine("\n\n########################################################");
                Console.WriteLine("##### Enemy win! Please don't be sad, try again... #####");
                Console.WriteLine("########################################################");
            }
            else
            {
                Console.WriteLine("\n\n########################################################");
                Console.WriteLine("######################## It's a draw! ###################");
                Console.WriteLine("########################################################");
            }
            Console.ReadKey();
        }
    }
}
