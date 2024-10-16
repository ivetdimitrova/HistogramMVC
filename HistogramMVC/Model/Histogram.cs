using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistogramMVC.Model
{
    public class Histogram
    {
        private int[] numbers;

        private double p1;
        private double p2;
        private double p3;
        private double p4;
        private double p5;

        public double P1
        {
            get { return p1 / this.numbers.Length * 100.0;}
            set { this.p1 = value; }
        }
        public double P2 {
            get { return p2 / this.numbers.Length * 100.0; }
            set { this.p2 = value; }
        }
        public double P3 {
            get { return p3 / this.numbers.Length * 100.0; }
            set { this.p3 = value; }
        }
        public double P4 {
            get { return p4 / this.numbers.Length * 100.0; }
            set { this.p4 = value; }
        }
        public double P5 {
            get { return p5 / this.numbers.Length * 100.0; }
            set { this.p5 = value; }
        }

        public Histogram(int[] numbers)
        {
            this.numbers = numbers;
        }
        public void CalculateCount()
        {
            foreach (int number in this.numbers)
            {
                if (number < 200)
                {
                    this.p1++;
                }
                else if (number < 400)
                {
                    this.p2++;
                }
                else if (number < 600)
                {
                    this.p3++;
                }
                else if (number < 800)
                {
                    this.p4++;
                }
                else
                {
                    this.p5++;
                }
            }
        }
    }
}
