using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicHateBall
{
    public class Happy : IQuestion
    {
        static Happy()
        {
        }

        public string Answer()
        {
            Random rng = new Random();
            var r = rng.Next(1, 8);
            List<string> response = new List<string>();
            response.Add("Of Course!");
            response.Add("Without a doubt!");
            response.Add("YAASSS!");
            response.Add("Hmmmmm");
            response.Add("Ask again later");
            response.Add("Sorry, doesn't look good");
            response.Add("I'm afraid not");
            response.Add("Not likely");
            return response[r];

        }
        
    }
}
