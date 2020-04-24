using System;
using System.Runtime.Serialization;

namespace RSI.Models
{
    [DataContract]
    public class UpdateEvent
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
    }
}
