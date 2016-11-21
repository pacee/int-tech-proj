using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doitcar
{
    class RoutePart
    {
        public int commNumber { get; set; }
        public int seconds { get; set; }

        public RoutePart(int CommNumber, int Seconds)
        {
            this.commNumber = CommNumber;
            this.seconds = Seconds;
        }
    }
}
