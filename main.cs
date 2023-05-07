using System;
using MissionXRun;

namespace MissionXMenue
{
   class Menue : Run  {

      static void Main(string[] args) {
         //Run.run();
         clear();
      }

      static void clear() {
         for (int i = 0; i < 100; i++) {
            Console.WriteLine();
         }
      }
   }
}