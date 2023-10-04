using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.ProductosVendidos
{
    public class ProductoVendido
    {
        public long Id { get; set; }
        public long IdProducto { get; set; }
        public decimal Stock { get; set; }
        public long IdVenta { get; set; }
    }
}
