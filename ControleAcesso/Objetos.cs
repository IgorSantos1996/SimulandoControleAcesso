using System;
using System.Collections.Generic;
using System.Text;

namespace ControleAcesso
{
    class Objetos
    {
        public Acao ac { get; set; }
        public string  ?Arquivo01 { get; set; }
        public string ?Arquivo02 { get; set; }
        public string ?Socket01 { get; set; }
        public string ?Program { get; set; }

        public Objetos(Acao ac, string arquivo01, string arquivo02, string socket01, string program)
        {
            this.ac = ac;
            Arquivo01 = arquivo01;
            Arquivo02 = arquivo02;
            Socket01 = socket01;
            Program = program;
        }
    }
}
