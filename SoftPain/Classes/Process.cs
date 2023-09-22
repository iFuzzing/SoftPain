using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftPain.Classes
{
    public class Process
    {
        public string Name {  get; set; }
        public uint Pid { get; set; }

        public Process(string name, uint pid) {
            Name = name;
            Pid = pid;
        }
    }
}
