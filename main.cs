using System;
using MissionXRun;

namespace MissionXMenue
{
   class Menue {

      static void Main(string[] args) {
         Console.Clear();
   
         showInstruction();
         showMenue();

         do {
            //Console.SetCursorPosition(0,10);
            //Console.SetCursorPosition(0,10);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("⟫ ");
            Console.ForegroundColor = ConsoleColor.White;

            string command = Console.ReadLine();

            if (command == "m") {
               Console.Write("");
               Console.Write("");
               showMenue();
            }

            if (command == "l") {
               Environment.Exit(0);
            }

            if (command == "i") {
               showCommands();
            }
            if (command == "s") {
               start();
            }

         } while (true);     
      }

      

      static void showInstruction() { // Instruction and Name
         //Console.SetCursorPosition(0,1);
         showLogo();
         Console.WriteLine("");
         Console.WriteLine("");
         Console.ForegroundColor = ConsoleColor.White;
         Console.Write("This Game is named "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("MissionX ");
         Console.ForegroundColor = ConsoleColor.White; Console.WriteLine("and the goal is to land the rocket which is in air."); 
         Console.WriteLine("You have only a bit fuel to land it, so save your fuel. Good luck!");
         Console.WriteLine("");
         Console.WriteLine("");
         Console.WriteLine("");
         Console.WriteLine("");
      }

      static void showLogo() {
         Console.ForegroundColor = ConsoleColor.Green;
         Console.WriteLine("               ++++          ++++     ++    ++");
         Console.WriteLine("               ++ ++        ++ ++      ++  ++");
         Console.WriteLine("               ++  ++      ++  ++       ++++");
         Console.WriteLine("               ++   ++    ++   ++       ++++");
         Console.WriteLine("               ++    ++  ++    ++      ++  ++");
         Console.WriteLine("               ++     ++++     ++     ++    ++");
         

      }

      static void showMenue() {
         Console.ForegroundColor = ConsoleColor.DarkYellow;
         //Console.SetCursorPosition(0,2);
         Console.WriteLine("               MENUE");
         Console.WriteLine("");
         Console.WriteLine("");
         Console.ForegroundColor = ConsoleColor.White;
         Console.WriteLine("- Press \"s\" to start"); 
         Console.WriteLine("- Press \"l\" to leave the game");
         Console.WriteLine("- Press \"i\" to get infos how to controll in game.");
         Console.WriteLine("- Press \"m\" to go back to the menue");
         Console.WriteLine("");
         Console.WriteLine("");
      }

      static void showCommands() {
         Console.WriteLine("");
         Console.WriteLine("");
         Console.ForegroundColor = ConsoleColor.Green;
         Console.Write("-↑ : "); // key
         Console.ForegroundColor = ConsoleColor.White;
         Console.WriteLine("Press for more thrust"); // Command discription
         Console.ForegroundColor = ConsoleColor.Green; 
         Console.Write("-↓ : "); // key
         Console.ForegroundColor = ConsoleColor.White;
         Console.WriteLine("Press for less thrust"); // Command discription
         Console.WriteLine("");
         Console.WriteLine("");
      }

      static void start() {
         

      }
      static void clearGameField(){
       

      }

   }
}