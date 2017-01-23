using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicHateBall
{
    public class Sad : IQuestion
    {
        public Sad()
        {
        }

            
        public string Answer()
        {
            Random rng = new Random();
            var r = rng.Next(1, 8);
            List<string> response = new List<string>();
            response.Add("Unfortunately, yes");
            response.Add("Afraid so");
            response.Add("probably");
            response.Add("idk");
            response.Add("You should ask someone else");
            response.Add("nope, never");
            response.Add("Just like your last relationship, it'll never work");
            response.Add("If your mom had hugged you more, you might have had a chance");
            return response[r];
        }
    }
}
