using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicHateBall
{
    public class Robot : IQuestion
    {
        public Robot()
        {
        }
        public string Answer()
        {
            Random rng = new Random();
            var r = rng.Next(1, 8);
            List<string> response = new List<string>();
            response.Add("0111100101100101011100110000110100001010");
            response.Add("Y");
            response.Add("Success");
            response.Add("Update needed");
            response.Add("404 - Answer Not Found");
            response.Add("Does not compute");
            response.Add("01101110011011110000110100001010");
            response.Add("I'm sorry Dave, I'm afraid you can't do that");
            return response[r];
        }
    }
}
