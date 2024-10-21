namespace BookStore.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        List<Autor> Autors { get; set; } = new List<Autor>();
    }
}
