using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube_da_leitura
{
    public class TelaEmprestimo
    {
        public RepositorioEmprestimi repositorioEmprestimo = null;

        public void MostrarEmprestimos()
        {
            ArrayList emprestimos = repositorioEmprestimo.SelecionarTodos();

            foreach (Emprestimo e in emprestimos)
            {
                Console.WriteLine(e.datalimite + "," + e.amigo.nome + "," +e.data + "," + e.revista.titulo);
            }

            public void CadastrarRevis
            {
                Caixa caixa = new Caixa();
                caixa.id = Convert.ToInt32(Console.ReadLine());
                caixa.etiqueta = Console.ReadLine();
                caixa.cor = Console.ReadLine();






                repositorioCaixa.Inserir(caixa);
            }

        }





    }
}
