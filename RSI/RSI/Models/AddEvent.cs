using System;
using System.Runtime.Serialization;

namespace RSI.Models
{
    [DataContract]
    public class AddEvent
    {
        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Type { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}
