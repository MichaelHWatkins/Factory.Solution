using System.Collections.Generic;

namespace Factory.Models
{
    public class Machine
    {
        public Machine()
        {
            this.JoinEntities = new HashSet<EngineerMachine>();
        }

        public int MachineID { get; set; }
        public string MachineName { get; set; }

        public virtual ICollection<EngineerMachine> JoinEntities { get;}
    }
}