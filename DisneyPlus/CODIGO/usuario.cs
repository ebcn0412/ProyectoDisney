using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisneyPlus.CODIGO
{
    class usuario
    {
        int usuarioID { get; set; }
        string nombre { get; set; }
        string correo { get; set; }
        
        public usuario()
        {

        }

        public usuario(int codigo, string name, string email)
        {
            usuarioID = codigo;
            nombre = name;
            correo = email;
        }
    }
}
