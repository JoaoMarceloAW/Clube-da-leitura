﻿using ClubeLeitura.ModuloAmigo;
using ClubeLeitura.ModuloReista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeLeitura.ModuloEmprestimo
{
    public class Emprestimo
    {
        public int id;
        public DateTime dataEmprestimo;
        public DateTime dataDevolucao;
        public Revista revista;
        public Amigo amiguinho;

        public bool estaAberto;

        public Emprestimo(DateTime dataEmprestimo, Revista revista, Amigo amiguinho)
        {
            this.dataEmprestimo = dataEmprestimo;
            this.revista = revista;
            this.amiguinho = amiguinho;
            estaAberto = true;
        }

        public void Fechar()
        {
            if (estaAberto)
            {
                estaAberto = false;
    }            dataDevolucao = DateTime.Now;
            }


    }
}
