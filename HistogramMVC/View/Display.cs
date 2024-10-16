using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HistogramMVC.View
{
    public class Display
    {
        public int[] Numbers { get; set; }

        public  double P1 { get; set; }
        public double P2 { get; set; }
        public double P3 { get; set; }
        public double P4 { get; set; }
        public double P5 { get; set; }

        public void Input()
        {

            int count = int.Parse(Console.ReadLine());
            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            this.Numbers = numbers;
        }

        public void Output()
        {
            //Console.WriteLine($"Числата , които са под 200 са:{this.P1:f2}%");
            //Console.WriteLine($"Числата , които са от 200 до 399 са:{this.P2 :f2}%");
            //Console.WriteLine($"Числата , които са от 400 до 599 са:{this.P3 :f2}%");
            //Console.WriteLine($"Числата , които са от 600 до 799 са:{this.P4:f2}%");
            //Console.WriteLine($"Числата , които са от 800 нагоре са:{this.P5:f2}%");

            Console.WriteLine($"{this.P1:f2}%");
            Console.WriteLine($"{this.P2:f2}%");
            Console.WriteLine($"{this.P3:f2}%");
            Console.WriteLine($"{this.P4:f2}%");
            Console.WriteLine($"{this.P5:f2}%");
        }
    }
}
