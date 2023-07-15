namespace MarketPlace.Dtos {
public class ProductDTO {
  public int Id { get; set; }
  public string Title { get; set; } = string.Empty;
  public int Qty { get; set; } = 0;
  public string Description { get; set; } = string.Empty;
  public double Price { get; set; } = 0;
  public string Thumbnail { get; set; } = string.Empty;
  public ICollection<ProductImageDTO> ProductImages { get; set; }
  public double ShippingFee { get; set; } = 0;
  public int CategoryId { get; set; }
  public int SubCategoryId { get; set; }
  public int StoreId { get; set; }
  public virtual CategoryDTO Category { get; set; } = new CategoryDTO();
  public virtual SubCategoryDTO SubCategory { get;
                                              set; } = new SubCategoryDTO();
  public virtual StoreDTO Store { get; set; } = new StoreDTO();
}
}
