using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRCCalc.Algorithms
{
    interface IAlgorithms
    {
        bool GetCRCBytes(byte[] inputBytes, ref byte[] crcBytes);
    }
}
