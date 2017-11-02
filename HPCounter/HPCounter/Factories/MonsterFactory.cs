using HPCounter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPCounter.Factories
{
    public static class MonsterFactory
    {
        public static IMonster CreateMonster(string name ,int maxHP)
        {
            Monster monster = new Monster { Name = name, MaxHP = maxHP, CurrentHP = maxHP };
            return monster;
        }
    }
}
