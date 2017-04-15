using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MentoringD1D2.Module2.Task3.Helpers;

namespace MentoringD1D2.Module2.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOfStrings =
               {
                "quiy",
                null,
                "do",
                null,
                "winter",
                "deLimeter",
                "121_number",
                "wonderful",
                "air",
                "История",
                "string",
                "stringExample",
                "mark",
                "человек",
                "902 ^bb",
                "#$!",
                "Da"
            };
            for (int i= 0; i < arrayOfStrings.Length; i++)
            {
                Console.WriteLine($"{i+1}. {arrayOfStrings[i]}");
            }

            Console.WriteLine("--------------Result-------------");
            Console.WriteLine(arrayOfStrings.CustomStringConcatenate());
            Console.ReadKey();
        }
    }
}
