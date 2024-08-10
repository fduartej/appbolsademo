using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace appdemo.Models
{
    public class Ordenes
    {
        public string? Instrumento { get; set; }
        public decimal? Precio { get; set; }

        public string? TipoPrecio { get; set; }
        public int? Cantidad { get; set; }

        public decimal Costo { get;}
        public decimal Tax { get;}
        public decimal Total { get;}

        public Ordenes(string _instrumento, decimal _precio, string _tipoPrecio, int _cantidad)
        {
            Instrumento = _instrumento;
            Precio = _precio;
            TipoPrecio = _tipoPrecio;
            Cantidad = _cantidad;
            Costo = (decimal)(Precio * Cantidad);
            Tax = Costo * 0.18m;
            Total = Costo + Tax;
        }
        
    }
}