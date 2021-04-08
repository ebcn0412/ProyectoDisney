using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisneyPlus.CODIGO.USUARIO
{
    class usuario
    {
        public int usuarioID;
        public string nombre;
        public string correo;
        
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
