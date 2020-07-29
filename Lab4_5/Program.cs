
using System;
using System.Collections.Generic;

namespace _4_5LabSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> scores = new List<int>();
            scores.Add(1200);
            scores.Add(4400);
            scores.Add(3700);
            scores.Add(8900);
            scores.Add(7200);


            
            scores.Sort();

            foreach (int s in scores)
            {
                Console.WriteLine(s);
            }

            
            scores.Reverse();

            foreach (int s in scores)
            {
                Console.WriteLine(s);
            }

            
            scores.Add(2400);

          
            scores.Remove(4400);

        }
    }
}