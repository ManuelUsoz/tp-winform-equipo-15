using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int CodNumero { get; set; }
        public string Nombre { get; set;}
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public string ImagenURL { get; set; }
        public int Precio { get; set; }
    }
}
