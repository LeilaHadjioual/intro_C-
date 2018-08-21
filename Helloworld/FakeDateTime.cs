using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    public class FakeDateTime : IDateTime
    {

        //constructeur
        public FakeDateTime(DateTime fakeDate)
        {
            Date = fakeDate;
        }

        //property interface IdateTime
        public DateTime Date { get; }
    }
}
