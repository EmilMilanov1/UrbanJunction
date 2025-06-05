namespace UrbanJunction.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Category
    {
        public Category()
        {
            IsDeleted = false;
        }
        public Category(int id, string name)
        {
            Id = id;
            Name = name;
            IsDeleted = false;
        }

        [Key]
        public int Id { get; init; }

        [Required, MaxLength(50)]
        public string Name { get; set; } = null!;

        public IEnumerable<Topic> Topics { get; set; } = new List<Topic>();

        public bool IsDeleted { get; set; }
    }
}
