using System.ComponentModel.DataAnnotations;

namespace lemosinfotec.matrixErp.UI.Models
{
    public class LoginViewModels
    {
        [Display(Name = "Usuário")]
        [Required]
        public string UserName { get; set; }

        [Display(Name = "Senha")]
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
    }
}
