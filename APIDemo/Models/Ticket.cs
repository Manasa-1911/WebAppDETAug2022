namespace APIDemo.Models
{
    public class Ticket
    {
        public int id { get; set; }
        public string BookedBy { get; set; }
        public string BookedFor { get; set; }
        public int Qty { get; set; }
        public int price { get; set; }
    }
}
