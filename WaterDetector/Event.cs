using System;
using System.Collections.Generic;
using System.Text;

namespace WaterDetector
{

    public delegate void EventHandler(object sender, EventArgs e);

    class EventArgs
    {
        public EventArgs(int value, int capacity)
        {
            Value = value;
            Capacity = capacity;
        }

        public int Value { get; set; }
        public int Capacity { get; set; }
    }
}
