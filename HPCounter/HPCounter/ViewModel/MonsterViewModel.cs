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
        public List<IMonster> Monsters;
        public Monster test;

        public MonsterViewModel()
        {
            Monsters = new List<IMonster>();
            test = new Monster("test", 10);

            //temp
            Monsters.Add(new Monster("Monster1", 10));
            Monsters.Add(new Monster("Monster2", 10));
            Monsters.Add(new Monster("Monster3", 10));
            Monsters.Add(new Monster("Monster4", 10));
        }

        public int x { get; set; }
    }
}

