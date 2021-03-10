using System;
using System.Collections.Generic;

namespace GeneriskaKlasserÖvning
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> vegetables = new Dictionary<string, int>();

            vegetables.Add("potato", 20);
            vegetables.Add("carrot", 12);
            vegetables.Add("salad", 10);

            Console.WriteLine("potato: " + vegetables["potato"]);
            Console.WriteLine("carrot: " + vegetables["carrot"]);
            Console.WriteLine("salad: " + vegetables["salad"]);

            bool gameLoop = true;
            int money = 50;

            while (gameLoop == true)
            {
                Console.WriteLine("What do you want to do? Buy or Leave?");
                string svar = Console.ReadLine().ToLower();
                if (svar == "buy" && money > 10)
                {
                    money = purchase(money, vegetables["potato"], vegetables["carrot"], vegetables["salad"]);

                    Console.WriteLine("You have " + money + " left.");
                }
                else if (svar == "buy" && money < 10)
                {
                    Console.WriteLine("You can't afford anyting in the store!");
                }
                else if( svar == "leave")
                {
                    Console.WriteLine("Bye!");
                    gameLoop = false;
                    
                }
                else
                {
                    Console.WriteLine("Error: Wrong input, please try again.");
                    
                }
                Console.ReadLine();
            }



        
        }

        static int purchase(int money, int potato, int carrot, int salad)
        {
            Console.WriteLine("what do you want to buy?");
            string ans = Console.ReadLine().ToLower();
            bool correctAns = false;
            while (!correctAns)
            {
                if (ans == "carrot" )
                {
                    money = money - carrot;
                    correctAns = true;
                }
                else if (ans == "potato")
                {
                    money = money - potato;
                    correctAns = true;
                }
                else if (ans == "salad")
                {
                    money = money - salad;
                    correctAns = true;
                }
                else
                {
                    Console.WriteLine("You can only buy: potato, carrot or salad");
                    ans = Console.ReadLine().ToLower();
                }
                
            }
            return money;
        }
    }
}
