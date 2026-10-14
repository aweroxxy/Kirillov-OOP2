using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratornaya
{
    public abstract class Vehicle
    {
        public string Model { get; private set; }
        public int Power { get; private set; }

        public Vehicle(string model, int power)
        {
            Model = model;
            Power = power;
        }

        public virtual string GetInfo()
        {
            return $"Модель: {Model}, мощность: {Power} Л.С.";
        }

        public abstract double CalculateTax(); 
    }
}
