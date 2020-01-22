using System;
using System.Collections.Generic;
using System.Text;

namespace WaterDetector
{
    class EventSubscriber
    {
        public void OnValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString() + " value is now " + e.Value);
        }

        public void OnCapacityMessage(object sender, EventArgs e)
        {
            Console.WriteLine(sender.ToString() + "is already on/over maximal capacity" + e.Capacity);
        }
    }
}
