using System;

namespace dotnet_assign1
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Hello buyer!");
             decimal cost = 0.0m;
             String player1 = "messi";
                String player2 = "ronaldo";
               String player3 = "zlatan";
            while(true){
                Console.WriteLine("Enter a player name to buy or enter 'q' to quit");
                 Console.WriteLine("player1:messi\nplayer2:ronaldo\nplayer3:zlatan");
                 var str = Console.ReadLine();
                 if (str == "q") {
                    Console.WriteLine("Done!");
                    break;
                    }
                        switch(str){
                            case "messi":
                            cost = totalcost(100);
                              Console.WriteLine($"you have selected {player1}\ncost to buy this player is ${cost}"); 
                              break; 
                            
                             case "ronaldo":
                              cost = totalcost(75);
                              Console.WriteLine($"you have selected {player2}\ncost to buy this player is ${cost}"); 
                              break; 

                               case "zlatan":
                                cost = totalcost(50);
                              Console.WriteLine($"you have selected {player3}\ncost to buy this player is ${cost}"); 
                              break; 

                              default: 
                               Console.WriteLine("enter correct name");
                               break;
                        }
               

            }
        }
        static decimal totalcost(int cost) {
            return cost+10;
        }
    }
}
