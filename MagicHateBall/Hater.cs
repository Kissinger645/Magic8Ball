using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicHateBall
{
    public class Hater : IQuestion
    {
        public Hater()
        {
        }
        public string Answer()
        {
            Random rng = new Random();
            var r = rng.Next(1, 8);
            List<string> response = new List<string>();
            response.Add("This question is so bad, I wanna smack yo father");
            response.Add("The answer is so obvious, yo momma could figure it out");
            response.Add("Hate, hate, hate, hate, hate");
            response.Add("This question is so stupid, you probably trip on a wireless network");
            response.Add("Yo breath is so bad, I can't even think of an answer");
            response.Add("");
            response.Add("");
            response.Add("");
            return response[r];
        }
    }
}
