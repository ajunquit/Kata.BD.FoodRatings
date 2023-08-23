using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.BD.FoodRatings
{
    public class KataFoodRating
    {
        private const int RATE = 1;
        private const int ID = 0;
        public int FoodRatings(int n, int[][] ratings)
        {
            if (n != ratings.Length)
                throw new ArgumentException("n != lenght of x");

            var ids = ratings.Select(id => id[ID]).Distinct().ToList();

            double[][] result = new double[ids.Count][];

            for (int i = 0; i < ids.Count(); i++)
            {
                var rates = ratings.Where(row => row.Any(id => id == ids[i])).ToList();
                var average = rates.Select(rate => rate[RATE]).ToList().Average();
                result[i] = new double[] { ids[i], average };
            }

            var orderedByRate = result
                .OrderByDescending(rate => rate[RATE]);

            var maxRate = orderedByRate.FirstOrDefault()[RATE];

            var resultFilteredByMaxRate = orderedByRate
                .Where(row => row.Any(rate => rate == maxRate))
                .Min(id => id[ID]);

            return (int)resultFilteredByMaxRate;
        }
    }
}
