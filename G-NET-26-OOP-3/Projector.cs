using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_26_OOP_3
{
    public class Projector
    {
        public string Model { get; }
        public bool IsRunning { get; private set; }

        public Projector(string model)
        {
            Model = model;
            IsRunning = false;
        }

        public void Start()
        {
            if (IsRunning)
            {
                Console.WriteLine($"Projector [{Model}] is already running.");
                return;
            }
            IsRunning = true;
            Console.WriteLine($"Projector [{Model}] started. Ready to screen!");
        }

        public void Stop()
        {
            if (!IsRunning)
            {
                Console.WriteLine($"Projector [{Model}] is already off.");
                return;
            }
            IsRunning = false;
            Console.WriteLine($"Projector [{Model}] stopped.");
        }

        public override string ToString()
        {
            return $"Projector [{Model}] — Status: {(IsRunning ? "ON" : "OFF")}";
        }
    }
}
