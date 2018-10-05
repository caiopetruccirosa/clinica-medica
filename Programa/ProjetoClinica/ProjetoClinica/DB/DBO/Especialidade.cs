﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoClinica.DB.DBO
{
    public class Especialidade
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }


        public Especialidade(int id, string nome)
        {
            if (nome == null || nome.Trim() == "")
                throw new Exception("Nome nulo");

            this.Id = id;
            this.Nome = nome;
        }
    }
}