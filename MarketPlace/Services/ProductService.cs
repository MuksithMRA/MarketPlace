using AutoMapper;
using MarketPlace.Dtos;
using MarketPlace.Dtos.Responses;
using MarketPlace.Interfaces;
using MarketPlace.Models;
using MarketPlace.Utils;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace MarketPlace.Services
{
    public class ProductService : IProductService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public ProductService(DataContext context , IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        CommonResponse<ProductDTO> IProductService.addProduct(ProductDTO product)
        {
            throw new NotImplementedException();
        }

        CommonResponse<ProductDTO> IProductService.deleteProductById(int id)
        {
            throw new NotImplementedException();
        }

        async Task<CommonResponse<List<ProductDTO>>> IProductService.getAllProducts()
        {
            CommonResponse<List<ProductDTO>> response = new CommonResponse<List<ProductDTO>>();
            try
            {
                List<Product> products = await _context.Products.ToListAsync();
                if (products.Count > 0)
                {
                    List<ProductDTO> productDtos = new List<ProductDTO>();
                    products.ForEach(async (Product product) => {
                        ProductDTO productDTO = _mapper.Map<Product, ProductDTO>(product);

                        Category? category = await _context.Categories
                        .FirstOrDefaultAsync((category) => category.Id == product.CategoryId);
                        productDTO.Category = _mapper.Map<Category, CategoryDTO>(category!);

                        SubCategory? subCategory = await _context.SubCategories
                        .FirstOrDefaultAsync((subCategory) => subCategory.Id == product.SubCategoryId);
                        productDTO.SubCategory = _mapper.Map<SubCategory, SubCategoryDTO>(subCategory!);

                        Store? store = await _context.Stores
                        .FirstOrDefaultAsync((store) => store.Id == product.StoreId);
                        productDTO.Store = _mapper.Map<Store, StoreDTO>(store!);

                        productDtos.Add(productDTO);
                    });
                    response.Data = productDtos;
                    response.StatusCode = StatusCodes.Status200OK;
                    response.Message = "Products Getting success";
                }
                else
                {
                    response.StatusCode = StatusCodes.Status404NotFound;
                    response.Message = "No Products Found";
                }
            }
            catch (NullReferenceException ex) {
                response.Message = ex.Message;
            }catch(Exception ex)
            {
                response.Message = ex.Message;
            }
            return response; 
        }

        CommonResponse<ProductDTO> IProductService.getProductByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        CommonResponse<ProductDTO> IProductService.getProductById(int id)
        {
            throw new NotImplementedException();
        }

        CommonResponse<ProductDTO> IProductService.updateProduct(ProductDTO product)
        {
            throw new NotImplementedException();
        }
    }
}
