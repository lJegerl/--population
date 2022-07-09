using System;

namespace PopulationTask
{
    public static class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation <= 0 || visitors < 0 || currentPopulation <= 0 || currentPopulation < initialPopulation)
            {
                throw new ArgumentException("Something wrong");
            }

            if (percent < 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(percent));
            }

            int years = 0;
            double population = initialPopulation;
            while (population < currentPopulation)
            {
                years++;
                population *= 1 + (percent / 100);
                population += visitors;
            }

            return years;
        }
    }
}
