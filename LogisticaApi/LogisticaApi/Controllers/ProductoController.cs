
using LogisticaApi.Services.ProductoService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace LogisticaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService _productoService;
        public ProductoController(IProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet] 
        public async Task<ActionResult<List<Producto>>> GetAllProductos()
        {
            return _productoService.GetAllProductos();
        }

        [HttpGet("{idProducto}")]        
        public async Task<ActionResult<Producto>> GetProductoById(int idProducto)
        {
            var result = _productoService.GetProductoById(idProducto);
            if (result is null)
                return NotFound("No encontrado");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<Producto>>> AddProducto(Producto producto)
        {
            var result = _productoService.AddProducto(producto);
            return Ok(result);
        }

        [HttpPut("{idProducto}")]
        public async Task<ActionResult<List<Producto>>> UpdateProductoById(int idProducto, Producto request)
        {
            var result = _productoService.UpdateProductoById(idProducto, request);
            if (result is null)
                return NotFound("No encontrado");

            return Ok(result);
        }

        [HttpDelete("{idProducto}")]
        public async Task<ActionResult<List<Producto>>> DeleteProductoById(int idProducto)
        {
            var result = _productoService.DeleteProductoById(idProducto);
            if (result is null)        
                return NotFound("No encontrado");
           
            return Ok(result);
            
        }
    }
}
