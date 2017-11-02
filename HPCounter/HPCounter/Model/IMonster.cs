using System;
using System.Collections.Generic;

namespace HPCounter.Model
{
    public interface IMonster
    {
        Guid Id { get; set; }
        string Name { get; set; }
        int MaxHP { get; set; }
        int CurrentHP { get; set; }
        bool IsDead { get; set; }
        List<ICondition> Conditions { get; set; }
    }
}