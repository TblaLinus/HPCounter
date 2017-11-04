using HPCounter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPCounter.ViewModel
{
    public class MonsterViewModel : ViewModelBase, IMonsterViewModel
    {
        public List<IMonster> Monsters { get; set; }

        public MonsterViewModel()
        {
            Monsters = new List<IMonster>();

            //temp
            Monsters.Add(new Monster("Monster1", 10));
            Monsters.Add(new Monster("Monster2", 10));
            Monsters.Add(new Monster("Monster3", 10));
            Monsters.Add(new Monster("Monster4", 10));
            Monsters.Add(new Monster("Monster5", 10));
            Monsters.Add(new Monster("Monster6", 10));
            Monsters.Add(new Monster("Monster7", 10));
            Monsters.Add(new Monster("Monster8", 10));
        }
    }
}

