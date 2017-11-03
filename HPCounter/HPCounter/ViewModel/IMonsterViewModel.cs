using HPCounter.Model;
using System.Collections.Generic;

namespace HPCounter.ViewModel
{
    public interface IMonsterViewModel
    {
        List<IMonster> Monsters { get; set; }
    }
}