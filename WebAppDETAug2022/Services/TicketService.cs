using System.Xml.Linq;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Services
{
    public class TicketService
    {
        static List<Ticket> Tickets { get; }
        public bool IsGlutenFree { get; internal set; }



        static int nextId = 3;
        static TicketService()
        {
            Tickets = new List<Ticket>
                {
                    new Ticket {  ID = 1, Name="Movie 1",Price=2000},
                    new Ticket {  ID = 2, Name="Movie 2", Price=2000} 
                };
        }

        public static List<Ticket> GetAll() => Tickets;

        public static Ticket? Get(int id) => Tickets.FirstOrDefault(p => p.ID == id);

        public static void Add(Ticket ticket)
        {
            ticket.ID = nextId++;
            Tickets.Add(ticket);
        }

        public static void Delete(int id)
        {
            var ticket = Get(id);
            if (ticket is null)
                return;

            Tickets.Remove(ticket);
        }

        public static void Update(Ticket ticket)
        {
            var index = Tickets.FindIndex(p => p.ID == ticket.ID);
            if (index == -1)
                return;

            Tickets[index] = ticket;
        }
    }
}
