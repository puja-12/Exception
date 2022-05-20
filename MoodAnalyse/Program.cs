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
            while (true)
            {
                Console.WriteLine("Please choose the option :\n1)Happy or SAD Mood\n2)Using the Default and Parametterized Constructor\n3)Exception");
                int option = Convert.ToInt16(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        HappySadmood mood = new HappySadmood();
                        string result = mood.Analyse("I am in sad Mood");
                        Console.WriteLine(result);
                        break;
                    case 2:

                        refractor1 A2 = new();
                        string result2 = A2.Analyse();
                        Console.WriteLine("Using the Default Constructor here and Mood is :" + result2);                       
                    
                        refractor1 A3 = new("I am in Happy Mood");
                        string result3 = A3.Analyse();
                        Console.WriteLine("Using the Parameterized Constructor here and Mood is :" + result3);
                        break;
                    case 3:
                        MoodAnalyzerException A4 = new ();
                        string result4 = A4.ExceptionMethod(null);
                        break;
                }
            }
        }
    }
}