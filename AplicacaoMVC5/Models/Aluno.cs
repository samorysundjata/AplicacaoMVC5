﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AplicacaoMVC5.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Nome Completo")]
        [Required(ErrorMessage = "O campo {0} é requerido")]
        [MaxLength(100, ErrorMessage = "No máximo 100 caracteres")]
        public string Nome { get; set; }

        [DisplayName("E-mail")]
        [Required(ErrorMessage = "O campo {0} é requerido")]
        [EmailAddress(ErrorMessage = "Email em formato inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é requerido")]
        public string CPF { get; set; }
        
        public DateTime DataMatricula { get; set; }
        
        public bool Ativo { get; set; }
        
        //[Required(ErrorMessage = "O campo {0} é requerido")]
        //public string Senha { get; set; }

        //[Compare("Senha", ErrorMessage = "As senhas informadas não conferem")]
        //[Required(ErrorMessage = "O campo {0} é requerido")]
        //public string SenhaConfirmacao { get; set; }

    }
}