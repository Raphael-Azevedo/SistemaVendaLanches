using MVC2022.Models;
using System.ComponentModel.DataAnnotations;

namespace MVC2022.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o nome")]
        [Display(Name = "Usuário")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }    
        public string ReturnUrl { get; set; }   
    }
}
