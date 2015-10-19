
using System.ComponentModel.DataAnnotations;

namespace ConsoleApplication8.Domain
{
    
    public class Product
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public decimal Price { get; set; }

        public int CategoriaId { get; set; }
        public virtual Category Category { get; set; }
    }
}
