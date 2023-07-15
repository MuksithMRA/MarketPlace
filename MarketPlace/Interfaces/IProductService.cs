using MarketPlace.Dtos;
using MarketPlace.Dtos.Responses;

namespace MarketPlace.Interfaces {
public interface IProductService {

  public Task<CommonResponse<List<ProductDTO>>> getAllProducts();
  public CommonResponse<ProductDTO> deleteProductById(int id);
  public CommonResponse<ProductDTO> updateProduct(ProductDTO product);
  public CommonResponse<ProductDTO> addProduct(ProductDTO product);
  public CommonResponse<ProductDTO> getProductById(int id);
  public CommonResponse<ProductDTO> getProductByCategoryId(int categoryId);
}
}
