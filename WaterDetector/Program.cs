using System;
using System.Threading;
using System.Threading.Tasks;

namespace WaterDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            WaterTank wt1 = new WaterTank(100, "WT1");
            WaterTank wt2 = new WaterTank(10, "WT2");
            WaterTank wt3 = new WaterTank(500, "WT3");
            WaterTank wt4 = new WaterTank(50, "WT4");
            WaterTank wt5 = new WaterTank(25, "WT5");
            EventSubscriber sub = new EventSubscriber();

            wt1.ValueHasChanged += ReportChange;
            wt1.ValueHasChanged += sub.OnValueChanged;
            wt1.CapacityMessage += sub.OnCapacityMessage;
            wt2.ValueHasChanged += ReportChange;
            wt2.ValueHasChanged += sub.OnValueChanged;
            wt1.CapacityMessage += sub.OnCapacityMessage;
            wt3.ValueHasChanged += ReportChange;
            wt3.ValueHasChanged += sub.OnValueChanged;
            wt1.CapacityMessage += sub.OnCapacityMessage;
            wt4.ValueHasChanged += ReportChange;
            wt4.ValueHasChanged += sub.OnValueChanged;
            wt1.CapacityMessage += sub.OnCapacityMessage;
            wt5.ValueHasChanged += ReportChange;
            wt5.ValueHasChanged += sub.OnValueChanged;
            wt1.CapacityMessage += sub.OnCapacityMessage;

            while (true)
            {
                wt1.Add(r.Next(5));
                wt2.Add(r.Next(5));
                wt3.Add(r.Next(5));
                wt4.Add(r.Next(5));
                wt5.Add(r.Next(5));
                Thread.Sleep(1000);
            }
        }

        static void ReportChange(object sender, EventArgs e)
        {
            Console.WriteLine("Value was changed to " + e.Value);
        }
    }
}
