using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube_da_leitura
{
    public class RepositorioAmigo:RepositorioMae
    {
        private static ArrayList listaAmigos = new ArrayList();
        public void Inserir(Amigo amigo)
        {
           listaAmigos.Add(amigo);
        }

        public ArrayList OrdenarLista()
        {
            return listaAmigos;
        }

        public ArrayList SelecionarTodos()
        {
            return listaAmigos;
        }

        public Amigo SelecionarPorId(int id)
        {
            Amigo Amigo = null;

            foreach (Amigo c in listaAmigos)
            {
                if (c.id == id)
                {
                    Amigo = c;
                    break;
                }
            }

            return Amigo;

        }
    }
}
