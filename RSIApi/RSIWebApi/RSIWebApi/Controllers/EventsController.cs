using Microsoft.AspNetCore.Mvc;
using RSI.Core.Interfaces;
using RSI.Core.Models;
using System;

namespace RSIWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [TypeFilter(typeof(CustomFilter))]
    public class EventsController : ControllerBase
    {
        private readonly IEventService _eventService;
        private readonly IUserService _userService;

        public EventsController(IEventService eventService, IUserService userService)
        {
            _eventService = eventService;
            _userService = userService;
        }

        [HttpGet("All")]
        public IActionResult All()
        {
            return Ok(_eventService.GetAll());
        }

        [HttpGet("Id/{id}")]
        public IActionResult GetById(Guid id)
        {
            return Ok(_eventService.GetById(id));
        }

        [HttpGet("Year/{year}")]
        public IActionResult GetByYear(long year)
        {
            return Ok(_eventService.GetByYear(year));
        }

        [HttpGet("Year/{year}/Month/{month}")]
        public IActionResult GetByYearAndMonth(long year, long month)
        {
            return Ok(_eventService.GetByYearAndMonth(year, month));
        }

        [HttpGet("Year/{year}/Week/{week}")]
        public IActionResult GetByYearAndWeek(long year, long week)
        {
            return Ok(_eventService.GetByYearAndWeek(year, week));
        }

        [HttpGet("Year/{year}/Month/{month}/day/{day}")]
        public IActionResult GetByYearAndMonthAndday(long year, long month, long day)
        {
            return Ok(_eventService.GetByYearAndMonthAndDay(year, month, day));
        }

        [HttpPost]
        public IActionResult Post(AddEvent add)
        {
            return Ok(_eventService.Add(add));
        }

        [HttpPut]
        public IActionResult Put(UpdateEvent update)
        {
            return Ok(_eventService.Update(update));
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginDTO dTO)
        {
            return Ok(_userService.Login(dTO.Username, dTO.Password));
        }
    }

    public class LoginDTO
    {
        public string Username { get; set; }

        public string Password { get; set; }
    }
}
