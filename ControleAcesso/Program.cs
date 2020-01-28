using System;
using System.Collections.Generic;

namespace ControleAcesso
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sujeito> listinha = new List<Sujeito>();
            List<Objetos> listinhaObjetos = new List<Objetos>();

            //Para Alice
            listinhaObjetos.Add(new Objetos
                (new Acao("read", "write", "remove", null, null), "File1", null, null, null));

            listinhaObjetos.Add(new Objetos
               (new Acao("read", "write", null, null, null), null, "File2", null, null));

            listinhaObjetos.Add(new Objetos
               (new Acao(null, null, null, "execute", null), null, null, null, "Program"));

            listinhaObjetos.Add(new Objetos
               (new Acao(null, "write", null, null, null), null, null, "Socket1", null));

            listinha.Add(new Sujeito("Alice", listinhaObjetos));


            foreach (Sujeito s in listinha)
            {
                Console.WriteLine(s.nome);
                foreach (Objetos obj in listinhaObjetos)
                {
                    Console.WriteLine(obj.ac.ToString());

                }
            }

        }
    }
}
