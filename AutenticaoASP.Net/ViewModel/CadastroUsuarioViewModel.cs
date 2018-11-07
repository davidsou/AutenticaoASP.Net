using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutenticaoASP.Net.ViewModel
{
    public class CadastroUsuarioViewModel
    {
        [Required(ErrorMessage ="Informe seu nome.")]
        [MaxLength(100, ErrorMessage ="O nome de ter até 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe seu Login")]
        [MaxLength(50, ErrorMessage = "O Login de ter até 50 caracteres.")]
        public string  Login { get; set; }
       
        [Required(ErrorMessage = "Informe a Senha.")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "A senha deve ter pelo menos caracteres.")]
        public string  Senha { get; set; }

        [Required(ErrorMessage = "Informe a Senha.")]
        [DataType(DataType.Password)]
        [Display(Name ="Confirmar senha")]
        [MinLength(6, ErrorMessage = "A senha deve ter pelo menos caracteres.")]
        [Compare(nameof(Senha),ErrorMessage ="A senha e a confirmação não estão iguais")]
        public string ConfirmacaoSenha { get; set; }
    }
}