using APIDemo.Models;

namespace APIDemo.Services
{
    public class TicketService
    {
        static List<Ticket> Tickets { get; }
        static TicketService()
        {
            Tickets = new List<Ticket>
                {
                    new Ticket {  id = 1, BookedFor="Movie 1",price=200,Qty=2},
                    new Ticket {  id = 2, BookedFor="Movie 2", price=300,Qty=3},
                    new Ticket {  id = 3, BookedFor="Movie 3", price=350,Qty=5}
                };
        }

        public static List<Ticket> GetAll() => Tickets;

        public static Ticket Get(int id)
        {
            Ticket ticket = Tickets.FirstOrDefault(p => p.id == id);
            return ticket;
        }
    }
}
