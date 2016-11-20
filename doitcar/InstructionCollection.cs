using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doitcar
{
    class InstructionCollection
    {
        List<Instruction> list = new List<Instruction>();

        public List<Instruction> getInstructions()
        {
            this.list.Add(new Instruction(0, "Stop"));
            this.list.Add(new Instruction(1, "Forward"));
            this.list.Add(new Instruction(2, "Backward"));
            this.list.Add(new Instruction(3, "Left"));
            this.list.Add(new Instruction(4, "Right"));
            this.list.Add(new Instruction(6, "A speed up"));
            this.list.Add(new Instruction(7, "A speed down"));
            this.list.Add(new Instruction(8, "B speed up"));
            this.list.Add(new Instruction(9, "B speed down"));

            return this.list;        
        }
    }
}
