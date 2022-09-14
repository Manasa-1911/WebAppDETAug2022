using System.ComponentModel.DataAnnotations;

namespace ClassLib_Pizza
{
    public class Pizza
    {
        public int Id { get; set; }

     
        public string? Name { get; set; }
        public PizzaSize Size { get; set; }
        public bool IsGlutenFree { get; set; }

      
        public decimal Price { get; set; }
    }

    public enum PizzaSize { Small, Medium, Large }
}
