using System;

namespace RSI.Core.Models
{
    public abstract class BaseEvent
    {
        public virtual DateTime Date { get; set; }

        public virtual string Name { get; set; }

        public virtual string Type { get; set; }

        public virtual string Description { get; set; }
    }
}
