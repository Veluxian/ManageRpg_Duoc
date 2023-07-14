using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRPG.Modelo
{
    public class Objeto
    { 
        public int id_objeto { get; set; }
        public string nombre_objeto { get; set; }
        public string descripcion_objeto { get; set; }
        public int peso_objeto { get; set; }
        public int valor_objeto { get; set; }
        public int cantidad_objeto { get; set; }
    }
}
