﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    public class Ticket
    {
        //properties
        public string Name { get; set; }

        public decimal Price { get; set; }

        public int AvailableTickets { get; set; }

        //constructors
        public Ticket( string name, decimal price, int availableTicket)
        {
            Name = name;
            Price = price;
            AvailableTickets = availableTicket;
        }
        
        //methods
        public override string ToString()
        {
            return $" {Name} - {Price:C} [Available - {AvailableTickets}]";
          
        }


    }

}
