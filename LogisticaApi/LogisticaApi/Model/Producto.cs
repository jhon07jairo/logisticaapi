using System.ComponentModel.DataAnnotations;

namespace LogisticaApi.Model
{
    
    public class Producto
    {
        public int IdProducto { get; set; } 
        public int IdTipoProducto { get; set; }
        public string Nombre { get; set; } = string.Empty;   
        public double Precio { get; set; }   
    }
}
