using HPCounter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPCounter.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public IMonsterViewModel MonsterViewModel { get; set; }
        //private Func<IMonsterViewModel> _monsterViewModelCreator;

        //public IMonsterViewModel MonsterViewModel
        //{
        //    get { return _monsterViewModel; }
        //    private set { _monsterViewModel = value; OnPropertyChanged(); }
        //}

        public MainViewModel(IMonsterViewModel monsterViewModel)
        {
            MonsterViewModel = monsterViewModel;
            //_monsterViewModelCreator = monsterViewModelCreator;
            //MonsterViewModel = _monsterViewModelCreator();
        }
    }
}
