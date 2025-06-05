namespace UrbanJunction.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static UrbanJunction.Data.Constants.DataConstants.HouseConstants;

    public class Topic
    {
        public Topic()
        {
            IsDeleted = false;
        }
        public Topic(int id, string title, string address, string description, string imageUrl, decimal Price)
        {
            Id = id;
            Title = title;
            Address = address;
            Description = description;
            ImageUrl = imageUrl;
            PricePerMonth = Price;
        }

        [Key]
        public int Id { get; init; }

        [Required, MaxLength(TitleMaxLength), MinLength(10)]
        public string Title { get; set; } = null!;

        [Required, MaxLength(150), MinLength(30)]
        public string Address { get; set; } = null!;

        [Required, MaxLength(500), MinLength(50)]
        public string Description { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required, Range(0, 2000), Column(TypeName = "decimal(12,3)")]
        public decimal PricePerMonth { get; set; }

        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        [Required]
        public Guid AgentId { get; set; }
        public Agent Agent { get; set; } = null!;

        public string? RenterId { get; set; }
        public IdentityUser? Renter { get; set; }

        public bool IsDeleted { get; set; }
    }
}
