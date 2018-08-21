using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    class RealDateTime : IDateTime
    {
        public DateTime Date
        {
            get
            {
                return DateTime.Now;
            }
        }
    }
}
