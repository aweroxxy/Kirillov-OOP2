using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratornaya
{
    public class Truck : Vehicle, IStorable
    {
        public double LoadCapacity { get; private set; }
        public string FilePath { get; private set; }

        public Truck(string model, int power, double loadCapacity) : base(model, power)
        {
            LoadCapacity = loadCapacity;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Грузоподьемность: {LoadCapacity} т";
        }

        public override double CalculateTax()
        {
            return Power * 25;
        }

        public void Save()
        {
            FilePath = "Truck.txt";
            File.WriteAllText(FilePath, GetInfo());
        }
    }
}
