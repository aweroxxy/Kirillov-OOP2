using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intrface_clone
{
    public class License : ICloneable
    {
        public string Key { get; private set; }
        public int DurationDays { get; private set; }

        public License(string key, int durationDays)
        {
            key = key;
            DurationDays = durationDays;
        }
        public object Clone()
        {
            return new License(Key, DurationDays);
        }
    }
}