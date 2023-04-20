using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clube_da_leitura
{
    public class TelaCaixa
    {
        public RepositorioCaixa RepositorioCaixa = null;

        public void MostrarCaixas(RepositorioCaixa repositorio)
        {
            ArrayList caixas = RepositorioCaixa.SelecionarTodos();

            foreach (Caixa caixa in caixas)
            {
                Console.WriteLine(caixa.id + ", "
                    + caixa.cor + ", " + caixa.etiqueta);
            }
            
            
         


        }
        public void CadastrarCaixa()
        {
            Caixa caixa = new Caixa();
            caixa.id = Convert.ToInt32(Console.ReadLine());
            caixa.etiqueta = 
            caixa.cor =





                RepositorioCaixa.Inserir(caixa);
        }
    }
}
