using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    public enum EventType
    {
        Music, Comedy, Theatre
    }
    public class Event : IComparable<Event>
    {
        public string Name { get; set; }
        public DateTime Eventdate { get; set; }

        public List<Ticket> Tickets { get; set; }

        public EventType TypeOfEvents { get; set; }

        //constriuctor
        public Event(string name, DateTime eventdate, EventType typeOfEvents)
        {
            Name = name;
            Eventdate = eventdate;
            TypeOfEvents = typeOfEvents;
            Tickets = new List<Ticket>();
        }
        public Event(): this("", DateTime.Now, EventType.Music)
        {
        }
        public Event(string name, DateTime eventdate, List<Ticket> tickets, EventType typeOfEvents): this(name, eventdate, typeOfEvents)
        {
            Tickets = tickets;
        }

        
          


        //methods
        //public void AddTicket(Ticket ticket)
        //{
        //    Tickets.Add(ticket);
        //}

        //public void RemoveTicket(Ticket ticket) { }

        public override string ToString()
        {
            return Name + " " + Eventdate + " " + TypeOfEvents;

        }

        public int CompareTo(Event other)
        {
            return this.Eventdate.CompareTo(other.Eventdate);
        }
    }
}
