using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratornaya
{
    internal interface IStorable
    {
        string FilePath { get; }
        public void Save();
    }
}
