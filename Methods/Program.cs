using System;
using System.Collections.Generic;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] movies = new string[3] { "Ipceotion", "Taken 1", "Rain man" };
            List<double> ranks = new List<double>();
            for (int i = 0; i < movies.Length; i++)
            {
                Console.WriteLine("Please Insert Your Rank (1 - 10) For The Movie :" + movies[i]+":");
                 double Ranks = Convert.ToInt32(Console.ReadLine());
                 ranks.Add(Ranks);
            }
            double Average = CalculateAverage(ranks);
            Console.WriteLine("The average Rank is :");
            Console.WriteLine(Average.ToString("F2"));
            Console.ReadKey();
        }
        public static double CalculateAverage(List<double> UserRanks)
        {
            double sum = 0;
            for (int i = 0; i < UserRanks.Count; i++)
            {
                sum += UserRanks[i];
            }
            double avg = sum / UserRanks.Count;
            return avg;
        }
    }
}
