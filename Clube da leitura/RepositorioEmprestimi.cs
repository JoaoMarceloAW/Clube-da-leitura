using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube_da_leitura
{
    public class RepositorioEmprestimi:RepositorioMae
    {
        private static ArrayList listaEmprestimos = new ArrayList();

        public void Inserir(Emprestimo emprestimo)
        {
            listaEmprestimos.Add(emprestimo);
        }
        public ArrayList OrdenarLista()
        {
            return listaEmprestimos;
        }
        public ArrayList SelecionarTodos()
        {
            return listaEmprestimos;
        }

    }
}
