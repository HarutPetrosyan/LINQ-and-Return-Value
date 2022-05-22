using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqRetValues
{
    internal class LINQBasedFieldsAreClunky
    {
        private static string[] currentVideoGames = {"Morrowind", "Uncharted 2",
"Fallout 3", "Daxter", "System Shock 2"};
        private IEnumerable<string> videoGames= from g in currentVideoGames where g.Contains(" ") orderby g select g;
        public void PrintGame()
        {
            foreach (var item in videoGames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
