namespace Clube_da_leitura
{
    internal class Program
    {
        static void Main(string[] args)
        {

            switch ()
            {
            
            }





          

            TelaCaixa telaCaixa = new TelaCaixa();
            telaCaixa.RepositorioCaixa = repositorioCaixa;

            telaCaixa.MostrarCaixas(repositorioCaixa);

            Revista revista = new Revista();
            revista.id = 1;
            revista.titulo = "As aventuras de superman";
            revista.ano = 2023;
            revista.caixa = repositorioCaixa.SelecionarPorId(1);

            RepositorioRevista repositorioRevista = new RepositorioRevista();
            repositorioRevista.Inserir(revista);

            TelaRevista telaRevista = new TelaRevista();
            telaRevista.repositorioRevista = repositorioRevista;
            telaRevista.MostrarRevistas();


            Amigo novoamigo = new Amigo();

            novoamigo.endereco = "Aguas Frias";
            novoamigo.nome = "Joao";
            novoamigo.telefone = "489882312";
            novoamigo.nomedoresposavel = "Lucas";
            novoamigo.id = 1;

            RepositorioAmigo repositorioAmigo = new RepositorioAmigo();
            repositorioAmigo.Inserir(novoamigo);
            TelaAmigo telaAmigo = new TelaAmigo();
            telaAmigo.repositorio = repositorioAmigo;
            telaAmigo.MotrarAmigo();


            Emprestimo emprestimo = new Emprestimo();
            emprestimo.data = "24/06";
            emprestimo.datalimite = "12/07";
            emprestimo.amigo = repositorioAmigo.SelecionarPorId(1);
            emprestimo.revista = repositorioRevista.SelecionarPorId(1);
            emprestimo.id = 1;

             RepositorioEmprestimi repositorioEmprestimo = new RepositorioEmprestimi();
            repositorioEmprestimo.Inserir(emprestimo);

            TelaEmprestimo telaemprestimo = new TelaEmprestimo();
            telaemprestimo.repositorioEmprestimo = repositorioEmprestimo;
            telaemprestimo.MostrarEmprestimos();






            Console.ReadLine();
        }
    }
    
}