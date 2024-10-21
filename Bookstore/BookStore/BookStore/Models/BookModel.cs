using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class BookModel
    {

        public int Id { get; set; }
        [Required]
        public string ?Name { get; set; } 
        public int AutorId { get; set; }
        [Required]
        Autor Autor { get; set; }
        List<BookModel>books { get; set; }
    }
}
