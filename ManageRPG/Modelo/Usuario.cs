using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRPG.Modelo
{
    public class Usuario
    {
        public int id_usuario { set; get; }
        public string usuario { set; get; }
        public string contrasenna { set; get; }
        public int id_rol { set; get; }
    }
}
