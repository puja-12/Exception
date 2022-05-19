using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyse
{
    public class refractor1
    {
        public refractor1()
        {

        }
        public string msg1 = "I am in sad mood";
        public refractor1(string meassage)
        {

            this.msg1 = meassage;
        }
        public string Analyse()
        {

            if (msg1.ToLower().Contains("sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }

        }
    }
}
