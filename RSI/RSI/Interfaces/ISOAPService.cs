using RSI.Models;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace RSI.Interfaces
{
    [ServiceContract]
    public interface ISOAPService
    {
        [OperationContract]
        Event Add(AddEvent model);

        [OperationContract]
        Event Update(UpdateEvent model);

        [OperationContract]
        IList<Event> GetAll();

        [OperationContract]
        Event GetById(Guid id);

        [OperationContract]
        IList<Event> GetByYear(long year);

        [OperationContract]
        IList<Event> GetByYearAndMonth(long year, long month);

        [OperationContract]
        IList<Event> GetByYearAndWeek(long year, long week);

        [OperationContract]
        IList<Event> GetByYearAndMonthAndDay(long year, long month, long day);

        [OperationContract]
        bool Login(string login, string password);

        void SetUsername(string username);
    }
}
