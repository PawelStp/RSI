using Microsoft.AspNetCore.Cors;
using RSI.Core.Interfaces;
using RSI.Interfaces;
using RSI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RSI.Services
{
    [EnableCors]
    public class SOAPService : ISOAPService
    {
        private readonly IEventService eventService;
        private readonly IUserService userService;

        public SOAPService(IEventService eventService, IUserService userService)
        {
            this.eventService = eventService;
            this.userService = userService;
        }

        public void SetUsername(string username)
        {
            eventService.SetUsername(username);
        }

        public IList<Event> GetByYearAndWeek(long year, long week)
        {
            var e = eventService.GetByYearAndWeek(year, week);

            return e.Select(x => new Event
            {
                CreatedBy = x.CreatedBy,
                Date = x.Date,
                Description = x.Description,
                Id = x.Id,
                Name = x.Name,
                Type = x.Type
            }).ToList();
        }

        public Event Add(AddEvent model)
        {
            var e = eventService.Add(new RSI.Core.Models.AddEvent
            {
                Description = model.Description,
                Date = model.Date,
                Name = model.Name,
                Type = model.Type
            });

            return new Event
            {
                CreatedBy = e.CreatedBy,
                Date = e.Date,
                Description = e.Description,
                Id = e.Id,
                Name = e.Name,
                Type = e.Type
            };
        }

        public Event Update(UpdateEvent model)
        {
            var e = eventService.Update(new RSI.Core.Models.UpdateEvent
            {
                Id = model.Id,
                Description = model.Description,
                Date = model.Date,
                Name = model.Name,
                Type = model.Type
            });

            return new Event
            {
                CreatedBy = e.CreatedBy,
                Description = e.Description,
                Id = e.Id,
                Name = e.Name,
                Date = e.Date,
                Type = e.Type
            };
        }

        public IList<Event> GetAll()
        {
            var e = eventService.GetAll();

            return e.Select(x => new Event
            {
                CreatedBy = x.CreatedBy,
                Date = x.Date,
                Description = x.Description,
                Id = x.Id,
                Name = x.Name,
                Type = x.Type
            }).ToList();
        }

        public Event GetById(Guid id)
        {
            var e = eventService.GetById(id);

            return new Event
            {
                CreatedBy = e.CreatedBy,
                Description = e.Description,
                Id = e.Id,
                Name = e.Name,
                Date = e.Date,
                Type = e.Type
            };
        }

        public IList<Event> GetByYear(long year)
        {
            var e = eventService.GetByYear(year);

            return e.Select(x => new Event
            {
                CreatedBy = x.CreatedBy,
                Date = x.Date,
                Description = x.Description,
                Id = x.Id,
                Name = x.Name,
                Type = x.Type
            }).ToList();
        }

        public IList<Event> GetByYearAndMonth(long year, long month)
        {
            var e = eventService.GetByYearAndMonth(year, month);

            return e.Select(x => new Event
            {
                CreatedBy = x.CreatedBy,
                Date = x.Date,
                Description = x.Description,
                Id = x.Id,
                Name = x.Name,
                Type = x.Type
            }).ToList();
        }

        public IList<Event> GetByYearAndMonthAndDay(long year, long month, long day)
        {
            var e = eventService.GetByYearAndMonthAndDay(year, month, day);

            return e.Select(x => new Event
            {
                CreatedBy = x.CreatedBy,
                Date = x.Date,
                Description = x.Description,
                Id = x.Id,
                Name = x.Name,
                Type = x.Type
            }).ToList();
        }

        public bool Login(string login, string password)
        {
            return userService.Login(login, password);
        }
    }
}