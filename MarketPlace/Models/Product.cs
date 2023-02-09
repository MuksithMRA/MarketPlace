using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

namespace MarketPlace.Models
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("name")]
        [MaxLength(255)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [Column("qty")]
        public int Qty { get; set; } = 0;

        [Required]
        [Column("description")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Column("price")]
        public double Price { get; set; } = 0;

        [Required]
        [Column("thumbnail")]
        [MaxLength(255)]
        public string Thumbnail { get; set; } = string.Empty;

        [Required]
        public ICollection<ProductImage> ProductImages { get; set; }

        [Required]
        [Column("shipping_fee")]
        public double ShippingFee { get; set; } = 0;

        [Column("category_id")]
        public int CategoryId { get; set; }

        [Column("sub_category_id")]
        public int SubCategoryId { get; set; }

        [Column("store_id")]
        public int StoreId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; } = new Category();

        [ForeignKey("SubCategoryId")]
        public virtual SubCategory SubCategory { get; set; } = new SubCategory();

        [ForeignKey("StoreId")]
        public virtual Store Store { get; set; } = new Store();

    }
}
