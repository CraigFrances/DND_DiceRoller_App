using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DND_DiceRoller_Library;

namespace DND_DiceRoller_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Roll is a static method
            Console.WriteLine(DiceRoller.RollD20());
            Console.ReadKey();
        }   
    }


    
}
