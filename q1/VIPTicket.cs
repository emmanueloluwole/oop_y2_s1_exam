using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    public class VIPTicket : Ticket
    {

        //PROPERTY
        public string AdditionalExtra { get; set; }
        public decimal AdditionalCost { get; set; }

  //CONSTRUCTOR
        public VIPTicket(string name, decimal price, int availableTicket, string additionalExtra, decimal additionalCost) : base(name, price, availableTicket)
        {
            AdditionalExtra = additionalExtra;
            AdditionalCost = additionalCost;
        }



        //METHOD
        public override string ToString()
        {
            return base.ToString() + " " + AdditionalExtra + " " + AdditionalCost;
        }
    }
}
