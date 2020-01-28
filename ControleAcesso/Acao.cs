using System;
using System.Collections.Generic;
using System.Text;

namespace ControleAcesso
{
    class Acao
    {
        public string? read { get; set; }
        public string? write { get; set; }
        public string? remove { get; set; }
        public string? execute { get; set; }

        public string? append { get; set; }

        public Acao(string read, string write, string remove, string execute, string append)
        {
            this.read = read;
            this.write = write;
            this.remove = remove;
            this.execute = execute;
            this.append = append;
        }

        public override string ToString()
        {
            string resul = null;
            if (read != null)
            {
                resul = read;
            }
            if (write != null)
            {
                resul += " " + write;
            }
            if (remove != null)
            {
                resul += " " + remove;
            }
            if (execute != null)
            {
                resul += " " + execute;
            }
            if (append != null)
            {
                resul += " " + append;
            }
            return resul;
        }
    }
}
