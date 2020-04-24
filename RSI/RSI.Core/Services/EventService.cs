using RSI.Core.Interfaces;
using RSI.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RSI.Core.Services
{
    class EventService : IEventService
    {
        private readonly IList<Event> events;
        private string _user;

        public EventService()
        {
            events = new List<Event>()
            {
                new Event
                {
                    Date = DateTime.UtcNow,
                    Description = "Przemka urodziny",
                    Id = Guid.NewGuid(),
                    CreatedBy= "Przemek",
                    Name = "Przemka urodziny",
                    Type = "Typ"
                },
                new Event
                {
                    Date = DateTime.UtcNow,
                    Description = "Przemka urodziny 1",
                    Id = Guid.NewGuid(),
                    CreatedBy="Przemek 1 " ,
                    Name = "Przemka urodziny 1",
                    Type = "Typ 1"
                },
                new Event
                {
                    Date = DateTime.UtcNow,
                    Description = "Przemka urodziny 2",
                    Id = Guid.NewGuid(),
                    CreatedBy="Przemek 2",
                    Name = "Przemka urodziny 2",
                    Type = "Typ 2"
                },
            };
        }

        public Event Add(AddEvent model)
        {
            var entity = new Event
            {
                Id = Guid.NewGuid(),
                Date = model?.Date ?? new DateTime(),
                Description = model?.Description,
                Name = model?.Name,
                Type = model?.Type,
                CreatedBy = _user
            };

            events.Add(entity);

            return entity;
        }

        public IList<Event> GetAll()
        {
            return events;
        }

        public Event GetById(Guid id)
        {
            return events.SingleOrDefault(x => x.Id == id);
        }

        public IList<Event> GetByYear(long year)
        {
            return events.Where(x => x.Year == year).ToList();
        }

        public IList<Event> GetByYearAndMonth(long year, long month)
        {
            return events.Where(x => x.Year == year && x.Month == month).ToList();
        }

        public IList<Event> GetByYearAndMonthAndDay(long year, long month, long day)
        {
            return events.Where(x => x.Year == year && x.Month == month && x.Day == day).ToList();
        }

        public IList<Event> GetByYearAndWeek(long year, long week)
        {
            return events.Where(x => x.Year == year && x.Week == week).ToList();
        }

        public void SetUsername(string username)
        {
            _user = username;
        }

        public Event Update(UpdateEvent model)
        {
            var entity = GetById(model.Id);

            entity.Description = model.Description;
            entity.Date = model.Date;
            entity.Name = model.Name;
            entity.Type = model.Type;

            return entity;
        }
    }
}
