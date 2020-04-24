using RSI.Core.Models;
using System;
using System.Collections.Generic;

namespace RSI.Core.Interfaces
{
    public interface IEventService
    {
        Event Add(AddEvent model);

        Event Update(UpdateEvent model);

        Event GetById(Guid id);

        IList<Event> GetAll();

        IList<Event> GetByYear(long year);

        IList<Event> GetByYearAndMonth(long year, long month);

        IList<Event> GetByYearAndWeek(long year, long week);

        IList<Event> GetByYearAndMonthAndDay(long year, long month, long day);

        void SetUsername(string username);
    }
}