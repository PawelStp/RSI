using System;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace RSI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        Event[] GetAll();

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    [DataContract(IsReference = true)]
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
