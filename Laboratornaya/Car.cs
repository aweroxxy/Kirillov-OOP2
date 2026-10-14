using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratornaya
{
    public class Car : Vehicle
    {
        public bool IsElectric { get; private set; }
        public Car(string model, int power, bool isElectric) : base(model, power)
        {
            IsElectric = isElectric;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $", Электрический: {IsElectric}";
        }

        public override double CalculateTax()
        {
            return Power * (IsElectric ? 5 : 12);
        }
    }
}
