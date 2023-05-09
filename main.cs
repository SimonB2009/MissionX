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
            Console.SetCursorPosition(0,10);
            Console.Write("        "); // delete last command
            Console.SetCursorPosition(0,10);

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
         Console.SetCursorPosition(0,20);
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
         Console.SetCursorPosition(0,1);
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
         clearGameField();
         Console.SetCursorPosition(0,20);
         Console.Write("Geschwindigkeit: ");
         Console.SetCursorPosition(40,20);
         Console.Write("Höhe:");
         Random rnd = new Random();

         for (int i = 1; i < 200; i++) {
            Thread.Sleep(100);
            Console.SetCursorPosition(19,20);
            Console.Write(rnd.Next(1,100));
            Console.SetCursorPosition(47,20);
            Console.Write(rnd.Next(100,300));
            if (i % 10 == 0) {
               Console.SetCursorPosition(60,i/10);  
               Console.Write("*");
               Console.SetCursorPosition(60,(i-1)/10);
               Console.Write(" ");
               Console.SetCursorPosition(0,20);
            }

        }

      }
      static void clearGameField(){
        Console.SetCursorPosition(0,20);
        for (int i = 0; i < 10; i++) {
         Console.WriteLine("                                                                                                 ");
        }

      }

   }
}