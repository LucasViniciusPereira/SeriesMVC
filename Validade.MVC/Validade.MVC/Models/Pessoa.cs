using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Validade.MVC.Models
{
    public class Pessoa
    {
        public int IdPessoa { get; set; }
        [Required(ErrorMessage="Nome é obrigatório")]
        public string  Nome { get; set; }

        [Required(ErrorMessage = "Idade é obrigatório")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Email é obrigatório")]
        [System.Web.Mvc.Remote("VerificaEmail","Home", ErrorMessage = "Este e-mail já está sendo utilizado")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Senha é obrigatório")]
        public string Senha { get; set; }

        [Compare("Senha",ErrorMessage = "As senha não se conferem")]
        public string ConfirmarSenha { get; set; }
    }
}
