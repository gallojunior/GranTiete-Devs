using System.ComponentModel.DataAnnotations;

namespace GranTiete_Devs.ViewModels;

public class LoginVM
{
    [Display(Name = "Email ou Nome de Usuário", Prompt = "Email ou Nome de Usuário")]
    [Required(ErrorMessage = "Por favor, informe seu Email ou Nome de Usuário")]
    [StringLength(100, ErrorMessage = "O Email deve conter no máximo 100 caracteres")]
    public string Email { get; set; }

    [Display(Name = "Senha de Acesso", Prompt = "Senha de Acesso")]
    [DataType(DataType.Password)]
    [Required(ErrorMessage = "Por favor, informe sua Senha")]
    [StringLength(30, ErrorMessage = "A Senha deve conter no máximo 30 caracteres")]
    public string Senha { get; set; }

    [Display(Name = "Manter Conectado?")]
    public bool Lembrar { get; set; } = false;

    public string UrlRetorno { get; set; }
}
