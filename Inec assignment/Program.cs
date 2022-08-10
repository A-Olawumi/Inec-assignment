using System;
using System.Linq;


namespace Inec_assignment
{
    internal class Program
    {                                   
        static void Main(string[] args)
        {
            //number 2//
            //Hashset should be used as this will help prevent multiple registration//


            string[] voters = {};
            var set = new HashSet<string>();
            var dup = voters.Where(x => !set.Add(x)).Distinct();

            Console.WriteLine(string.Join(" ,", dup));


            //number 1//

            string[] List = {"Adekunle Gold","Bukola switch", "Emily Sanders","Adebola Small","Doctor Strange","Bobby Slay",
                "Bola Tinubu","Adedire Olawumi","Adekunle Gold","Simi Gold", "Yemi Black","Ade love" ,"Yomi Green",
                "Bukola switch","Ololade Blue", "Ajanlekoko Yellow","whoisthat Femi ", "Bolaji Adewale","simi Gold","Adedire Olawumi","fidelis" };
            var duplicates = List.GroupBy(x => x)
            .Where(g => g.Count() > 1)
                .ToDictionary(x => x.Key, y => y.Count());
                 
            Console.WriteLine(string.Join(" \n", duplicates));





        }
    }
}