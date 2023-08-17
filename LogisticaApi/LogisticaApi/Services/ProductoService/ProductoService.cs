namespace LogisticaApi.Services.ProductoService
{
    public class ProductoService : IProductoService
    {
        private static List<Producto> Productos = new List<Producto> {
                new Producto {
                    IdProducto = 1,
                    IdTipoProducto = 1,
                    Nombre = "Producto Prueba",
                    Precio = 100
                },
                new Producto {
                    IdProducto = 2,
                    IdTipoProducto = 1,
                    Nombre = "Producto Prueba B",
                    Precio = 150
                }
            };


        public List<Producto> AddProducto(Producto producto)
        {   
            Productos.Add(producto);
            return Productos;
        }

        public List<Producto>? DeleteProductoById(int idProducto)
        {
            var producto = Productos.Find(x =>  x.IdProducto == idProducto);
            if (producto is null)
                return null;

            Productos.Remove(producto);
            return Productos;
        }

        public List<Producto> GetAllProductos()
        {
            return Productos;
        }

        public Producto? GetProductoById(int idProducto)
        {
            var producto = Productos.Find(x => x.IdProducto == idProducto);
            if (producto is null)
            {
                return null;
            }
            return producto;
        }

        public List<Producto>? UpdateProductoById(int idProducto, Producto request)
        {
            var producto = Productos.Find(x => x.IdProducto == idProducto);
            if (producto is null)            
                return null;
            

            producto.IdTipoProducto = request.IdProducto;
            producto.Nombre = request.Nombre;
            producto.Precio = request.Precio;

            return Productos;
        }
    }
}
