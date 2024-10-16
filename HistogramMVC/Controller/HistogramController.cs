using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HistogramMVC.Model;
using HistogramMVC.View;

namespace HistogramMVC.Controller
{
    public class HistogramController
    {
        private Display display;
        private Histogram histogram;

        public HistogramController()
        {
            display = new Display();
            display.Input();
            histogram = new Histogram(display.Numbers);
            histogram.CalculateCount();
            display.P1 = histogram.P1;
            display.P2 = histogram.P2;
            display.P3 = histogram.P3;
            display.P4 = histogram.P4;
            display.P5 = histogram.P5;
            display.Output();
        }
    }
}
