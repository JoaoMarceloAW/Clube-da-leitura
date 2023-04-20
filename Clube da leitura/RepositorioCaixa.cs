using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clube_da_leitura
{
    public class RepositorioCaixa : RepositorioMae
    {
 

        Caixa caixa1 = new Caixa();
            public void InserirCaixa(Caixa caixa)
            {
                listaRegistros.Add(caixa);
            }

            public void Criar(Caixa caixa)
            {
                InserirCaixa(caixa);
                contadorId++;
            }

         

            public void Deletar(int id)
            {
                Caixa caixa = SelecionarCaixaPorId(id);
                listaRegistros.Remove(caixa);
            }

            public ArrayList SelecionarTodos()
            {
                return listaRegistros;
            }

            public Caixa SelecionarCaixaPorId(int id)
            {
                Caixa caixa = null;

                foreach (Caixa a in listaRegistros)
                {
                    if (a.id == id)
                    {
                        caixa = a;
                        break;
                    }
                }
                return caixa;
            }
        }
    }



      
    }
}
