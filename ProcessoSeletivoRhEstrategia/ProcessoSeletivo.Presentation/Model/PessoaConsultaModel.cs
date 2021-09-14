﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProcessoSeletivo.Presentation.Model
{
    public class PessoaConsultaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Cpf { get; set; }
        public string  Nacionalidade{ get; set; }      
        public string  Cep{ get; set; }
        public string  Cidade{ get; set; }
        public string  Estado{ get; set; }
        public string  Logradouro{ get; set; }       
        public string  Email{ get; set; }      
        public string  Telefone{ get; set; }
    }
}