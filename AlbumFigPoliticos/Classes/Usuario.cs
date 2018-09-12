using System;
//using System.Collections.Generic;
using AlbumFigPoliticos.Generics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumFigPoliticos.Classes
{
    class Usuario
    {
        public string Nome;
        public string Login;
        public string Senha;
        public LinkedList<int> Arsenal;
        public LinkedList<int> FigurinhasColadas;
        public string UltimaData;

        public Usuario()
        {

        }
    }
}
