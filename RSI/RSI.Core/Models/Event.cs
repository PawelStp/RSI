namespace RSI.Core.Models
{
    public class Event : UpdateEvent
    {
        public virtual int Month => Date.Month;

        public virtual int Year => Date.Year;

        public virtual int Day => Date.Day;

        public virtual int Week => Date.DayOfYear / 7;

        public virtual string CreatedBy { get; set; }

    }
}
