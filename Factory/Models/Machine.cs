using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
    public class Machine
    {
        public int MachineId { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public int NumberInStock { get; set; }
        public List<EngineerMachine> JoinEntities { get; set; }
    }
}