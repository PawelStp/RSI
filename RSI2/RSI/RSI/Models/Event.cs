using System;
using System.Runtime.Serialization;

namespace RSI.Models
{
    [DataContract]
    public class Event
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string CreatedBy { get; set; }

        [DataMember]
        public int Month => Date.Month;

        [DataMember]
        public int Year => Date.Year;

        [DataMember]
        public int Day => Date.Day;
    }
}