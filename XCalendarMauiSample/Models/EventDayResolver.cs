﻿using System;
using System.Collections.Generic;
using System.Linq;
using XCalendar.Core.Interfaces;

namespace XCalendarMauiSample.Models
{
    public class EventDayResolver : ICalendarDayResolver
    {
        public IEnumerable<Event> Events { get; set; }
        public ICalendarDay CreateDay(DateTime? DateTime)
        {
            EventDay EventDay = new EventDay();
            UpdateDay(EventDay, DateTime);
            return EventDay;
        }
        public void UpdateDay(ICalendarDay Day, DateTime? DateTime)
        {
            EventDay EventDay = (EventDay)Day;
            EventDay.Events.ReplaceRange(Events.Where(x => x.DateTime.Date == DateTime?.Date));
            EventDay.DateTime = DateTime;
        }
    }
}
