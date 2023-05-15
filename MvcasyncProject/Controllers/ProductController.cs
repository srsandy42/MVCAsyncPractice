using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MvcasyncProject.Dto;
using MvcasyncProject.Models;
using MvcasyncProject.Repository;

namespace MvcasyncProject.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        public async Task<IActionResult> Index()
        {
            var products = await _productRepository.GetAllProductAsync();
            
            return View(products);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            var productDto = new ProductDto();

            return View(productDto);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductDto productDto)
        {
                var id = await _productRepository.AddProductAsync(productDto);
                return RedirectToAction("Index");
       
        }
        [HttpGet]
        public async Task<IActionResult> UpdateProduct( int id)
        {
            var products = await _productRepository.GetProductByIdAsync(id);
           
            return View(products);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(ProductDto productDto, int id)
        {
            await _productRepository.UpdateProductAsync(id, productDto);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> DeleteProduct( int id)
        {
            var products=await _productRepository.GetProductByIdAsync(id);
            return View(products);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteProduct(ProductDto productDto)
        {
             await _productRepository.DeleteProductAsync(productDto.Id);
            return RedirectToAction("Index");

        }
    }
}

