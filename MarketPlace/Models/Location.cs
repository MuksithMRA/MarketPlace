using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MarketPlace.Models
{
    [Table("Location")]
    public class Location
    {
        [Key , DatabaseGenerated(DatabaseGeneratedOption.Identity) ]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("address")]
        public string Address { get; set; } = string.Empty;

        [Required]
        [Column("latitude")]
        public double Latitude { get; set; } = 0;

        [Required]
        [Column("longitude")]
        public double Longitude { get; set; } = 0;

    }
}
