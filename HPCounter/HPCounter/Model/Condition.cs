using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPCounter.Model
{
    public class Condition : ICondition
    {
        public Guid Id { get; set; }
        public Status Status { get; set; }
        public int Duration { get; set; }

        public Condition()
        {
            Id = Guid.NewGuid();
        }
    }

    public enum Status
    {
        Prone,
        Asleep,
        Poisoned,
        Charmed,
        Afraid,
        Restrained
    }
}
