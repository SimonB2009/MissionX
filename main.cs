using System;
using MissionXRun;

namespace MissionXMenue
{
   class Menue : Run  {

      static void Main(string[] args) {
         clear();
         showInstruction();
         showMenue();
      }

      static void clear() { // first clear Console
         for (int i = 0; i < 100; i++) {
            Console.WriteLine();
         }
      }

      static void showInstruction() { // Instruction and Name
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
         Console.WriteLine("                             MENUE");
         Console.WriteLine("");
         Console.WriteLine("");
         Console.ForegroundColor = ConsoleColor.White;
         Console.WriteLine("-This Game is named MissionX and the goal is to land the rocket which is in air."); 
         Console.WriteLine("-You have only a bit fuel to land it, so save your fuel. Good luck!");
         Console.WriteLine("");
         Console.WriteLine("");
      }
   }
}