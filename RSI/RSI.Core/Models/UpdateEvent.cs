using System;

namespace RSI.Core.Models
{
    public class UpdateEvent : BaseEvent
    {
        public virtual Guid Id { get; set; }
    }
}
