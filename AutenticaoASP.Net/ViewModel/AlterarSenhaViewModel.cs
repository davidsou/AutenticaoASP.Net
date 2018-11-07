using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutenticaoASP.Net.ViewModel
{
    public class AlterarSenhaViewModel
    {
        [Required(ErrorMessage = "Informe sua senha atual.")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha Atual")]
        [MinLength(6, ErrorMessage = "A senha deve ter pelo menos caracteres.")]
        public string SenhaAtual { get; set; }


        [Required(ErrorMessage = "Informe a Senha.")]
        [DataType(DataType.Password)]
        [Display(Name = "Nova Senha")]
        [MinLength(6, ErrorMessage = "A senha deve ter pelo menos caracteres.")]
        public string NovaSenha { get; set; }

        [Required(ErrorMessage = "Confirme sua nova Senha.")]
        [DataType(DataType.Password)]        
        [Display(Name = "Confirmar senha")]
        [MinLength(6, ErrorMessage = "A senha deve ter pelo menos caracteres.")]
        [Compare(nameof(NovaSenha), ErrorMessage = "A senha e a confirmação não estão iguais")]
        public string ConfirmacaoSenha { get; set; }


    }
}