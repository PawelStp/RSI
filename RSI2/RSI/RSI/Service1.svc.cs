﻿using RSI.Core.Interfaces;
using RSI.Core.Services;
using RSI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RSI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private readonly IEventService eventService;

        public Service1()
        {
            this.eventService = new EventService();
        }

        public Event[] GetAll()
        {
            return eventService.GetAll().Select(x => new Event
            {
                CreatedBy = x.CreatedBy,
                Date = x.Date,
                Description = x.Description,
                Id = x.Id,
                Name = x.Name,
                Type = x.Type
            }).ToArray();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
