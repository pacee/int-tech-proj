using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doitcar
{
    class Instruction
    {
        public int commNumber { get; set; }
        public string commDesc { get; set; }

        public Instruction(int cm, string cd)
        {
            this.commNumber = cm;
            this.commDesc = cd;
        }

        public override string ToString()
        {
            return commNumber + " - " + commDesc;
        }
    }
}
