using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube_da_leitura
{
    public class TelaAmigo
    {
        public RepositorioAmigo repositorio = null;
        public void MotrarAmigo()
        {
            ArrayList amigos =  repositorio.SelecionarTodos();

            foreach (Amigo amigo in amigos)
            {
                Console.WriteLine(amigo.telefone + ", "
                    + amigo.nome + ", " + amigo.nomedoresposavel + ","+ amigo.endereco);
            }
        }
    }
}
