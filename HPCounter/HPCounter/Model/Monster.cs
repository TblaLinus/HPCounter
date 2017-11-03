using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPCounter.Model
{
    public class Monster : IMonster
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public bool IsDead { get; set; }
        public List<ICondition> Conditions { get; set; }

        public Monster(string name, int maxHP)
        {
            Id = Guid.NewGuid();
            Name = name;
            MaxHP = maxHP;
            CurrentHP = maxHP;
            IsDead = false;
            Conditions = new List<ICondition>();
        }
    }

    
}
