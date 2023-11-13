using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_CinemaAutomation.Entities
{
    internal class Ticket
    {
        public static List<Ticket> TicketList = new List<Ticket>();
        public string SurnameName { get; set; }
        public string SocialSecurityNo { get; set; }
        public string Gender { get; set; }
        public int TicketNumber { get; set; }

    }
}
