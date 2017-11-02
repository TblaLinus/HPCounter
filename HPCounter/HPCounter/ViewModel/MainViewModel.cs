using HPCounter.Factories;
using HPCounter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPCounter.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        public List<IMonster> Monsters;

        public MainViewModel()
        {
            Monsters = new List<IMonster>();

            //temp
            Monsters.Add(MonsterFactory.CreateMonster("Monster1", 10));
            Monsters.Add(MonsterFactory.CreateMonster("Monster2", 10));
            Monsters.Add(MonsterFactory.CreateMonster("Monster3", 10));
            Monsters.Add(MonsterFactory.CreateMonster("Monster4", 10));
        }
    }
}
