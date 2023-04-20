using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube_da_leitura
{
    public class RepositorioRevista: RepositorioMae
    {
        private static ArrayList listaRevistas = new ArrayList();

        public void Inserir(Revista revista)
        {
            listaRevistas.Add(revista);
        }
        public ArrayList OrdenarLista()
        {
            return listaRevistas;
        }

        public ArrayList SelecionarTodos()
        {
            return listaRevistas;
        }
        public Revista SelecionarPorId(int id)
        {
            Revista revista = null;

            foreach (Revista c in listaRevistas)
            {
                if (c.id == id)
                {
                    revista = c;
                    break;
                }
            }

            return revista;
        }
    }
}
