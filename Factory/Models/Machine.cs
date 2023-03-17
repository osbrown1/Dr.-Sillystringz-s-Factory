using System.Collections.Generic;

namespace Factory.Models
{
    public class Machine
    {
        public int MachineId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int NumberInStock { get; set; }
        public List<EngineerMachine> JoinEntities { get; set; }
    }
}