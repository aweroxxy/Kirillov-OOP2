using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Clone
{
    internal class Software : IComparable<License>, ICloneable
    {
        public string Title { get; private set; }
        public string Version { get; private set; }
        public decimal Price { get; private set; }
        public License SoftwareLicense { get; private set; }
    }
}
