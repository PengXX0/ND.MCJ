using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ND.MCJ.AOP.Logging;

namespace ND.MCJ.Tenpay
{
    class TenpayException : Exception
    {
        public TenpayException(string msg)
            : base(msg)
        {
            Logger.Error(msg);
        }
    }
}
