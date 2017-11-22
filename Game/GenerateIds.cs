using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMinesweeper
{
    class GenerateIds
    {
        int a = 15;
        int b = 15;
        public static void GenerateIds()
        {
            Random rnd = new Random();
            int cardAmount = Persistence.gridsizex * Persistence.gridsizey;
            int idAmount = cardAmount / 2;
            int[] ids = new int[cardAmount];
            int counter = 0;
            for (int i = 0; i < cardAmount; i += 2)
            {
                ids[i] = counter;
                ids[i + 1] = counter;
                counter++;

            }
            return ids.OrderBy(n => rnd.Next()).ToArray();
        }
    }
}
