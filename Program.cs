using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SennaLabs3 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("The winning number is ");
            string number = Console.ReadLine();
            string winning = number.Substring(4);
            Console.WriteLine(winning);
            string[] numbers = { "000", "00", "0", "" };
            for(int i = 0; i < 10000; i++) {
                if (i == 0) {
                    Console.WriteLine(numbers[i] + i.ToString() + winning);
                } else {
                    Console.WriteLine(numbers[(int)Math.Floor(Math.Log10(i))] +i.ToString() + winning);
                }
            }
            Console.ReadKey();
        }
    }
}
