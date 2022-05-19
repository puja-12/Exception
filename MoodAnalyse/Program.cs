// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyse
{
    class program
    {
        static void Main(string[] args)
        {
            HappySadmood mood = new HappySadmood();
            string result = mood.Analyse("I am in sad Mood");
            Console.WriteLine(result);
        }
    }
}