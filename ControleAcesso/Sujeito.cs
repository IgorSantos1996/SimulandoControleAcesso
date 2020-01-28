using System;
using System.Collections.Generic;
using System.Text;

namespace ControleAcesso
{
    class Sujeito
    {
        public List<Objetos> obj { get; set; }
        public string nome{ get; set; }

        public Sujeito( string name, List<Objetos> obj)
        {
            this.obj = obj;
            nome = name;

        }
       
    }
}
