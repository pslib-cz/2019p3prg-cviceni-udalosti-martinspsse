using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WaterDetector
{
    class WaterTank
    {
        private int _value = 0;
        private int _capacity = 0;

        public WaterTank(int capacity, string name)
        {
            Capacity = capacity;
            Name = name;
            Reset();
        }

        public int Capacity
        {
            get
            {
                return _capacity;
            }

            set
            {
                _capacity = Capacity;
                _value = value;

                if (_value >= _capacity)
                {
                    CapacityMessage?.Invoke(this, new EventArgs(value, capacity: Capacity));
                }

            }
        }
        public string Name { get; }
        public int CurrentValue
        {
            get
            {
                return _value;
            }

            set
            {
                _value = value;
                ValueHasChanged?.Invoke(this, new EventArgs(value, capacity: Capacity));
            }
        }

        public void Reset()
        {
            _value = 0;
        }

        public void Add(int value)
        {
            _value += value;
        }

        public event EventHandler ValueHasChanged;
        public event EventHandler CapacityMessage;
    }
}
