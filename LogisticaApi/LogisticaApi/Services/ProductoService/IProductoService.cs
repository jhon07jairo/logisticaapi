namespace LogisticaApi.Services.ProductoService
{
    public interface IProductoService
    {
        List<Producto> GetAllProductos();

        Producto? GetProductoById(int idProducto);

        List<Producto> AddProducto(Producto producto);

        List<Producto>? UpdateProductoById(int idProducto, Producto request);

        List<Producto>? DeleteProductoById(int idProducto);



    }
}
