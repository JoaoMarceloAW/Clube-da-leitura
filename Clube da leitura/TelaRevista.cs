using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube_da_leitura
{
    public class TelaRevista
    {
        public RepositorioRevista repositorioRevista = null;

        public void MostrarRevistas()
        {
            ArrayList revistas = repositorioRevista.SelecionarTodos();

            foreach (Revista r in revistas)
            {
                Console.WriteLine(r.id + ", " + r.titulo + ", " + r.caixa.etiqueta);
            }


        }
    }
}
