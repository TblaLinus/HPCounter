using System;

namespace HPCounter.Model
{
    public interface ICondition
    {
        int Duration { get; set; }
        Guid Id { get; set; }
        Status Status { get; set; }
    }
}