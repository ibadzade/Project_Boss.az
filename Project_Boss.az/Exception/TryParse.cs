using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinal.Exception1
{
    class TryParse : ApplicationException
    {
        public TryParse(string message) : base(message)
        {

        }
    }
}
