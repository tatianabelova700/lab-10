using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Corner corner= new Corner(20,"42","58");
            corner.Say();
            Console.ReadKey();
        }
    }
    class Corner
    {
        public string Min{ get; set; }
        public string Sec{ get; set; } 
        int gradus; 
        public int Gradus
        {
            set
            {
                if (value > 0)
                {
                 gradus = value;
                }
                else
                {
                    Console.WriteLine("Значение не должно быть отрицательным");
                }
            }
            get
            {
                return gradus;  
            }
        }
        public Corner (int gradus, string min, string sec)
        {
            Gradus = gradus;   
            Min = min; 
            Sec = sec; 
        }

        public Corner()
        {
        }

        public void Say()
        {
            Console.WriteLine("Градусов {0}. Минут{1}.Секунд {2}.", Gradus, Min, Sec);
        }
    }
}
